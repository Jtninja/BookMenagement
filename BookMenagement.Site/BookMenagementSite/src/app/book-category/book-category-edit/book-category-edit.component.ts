import { Component, OnInit, AfterViewInit, OnDestroy } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { BookCategory } from '../book-category';
import { BookCategoryService } from '../book-category.service';

@Component({
  selector: 'app-book-category-edit',
  templateUrl: './book-category-edit.component.html',
  styleUrls: ['./book-category-edit.component.css']
})
export class BookCategoryEditComponent implements OnInit, AfterViewInit, OnDestroy {

  pageTitle = 'Book Category Edit';
  errorMessage: string;

  CategoryForm: FormGroup;
  category: BookCategory;
  private sub: Subscription;
  
  constructor(private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private categoryService: BookCategoryService) {

  }


  ngOnInit(): void {
    this.CategoryForm = this.fb.group({
      categoryName: ['', [Validators.required,
                           Validators.minLength(3),
                           Validators.maxLength(150)]],
      categoryCode: ['', Validators.required]
      
    });

    // Read the product Id from the route parameter
    this.sub = this.route.paramMap.subscribe(
      params => {
        const id = +params.get('id');
        this.getCategory(id);
      }
    );
  }

  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }

  ngAfterViewInit(): void {
    // // Watch for the blur event from any input element on the form.
    // const controlBlurs: Observable<any>[] = this.formInputElements
    //   .map((formControl: ElementRef) => fromEvent(formControl.nativeElement, 'blur'));

    // // Merge the blur event observable with the valueChanges observable
    // merge(this.productForm.valueChanges, ...controlBlurs).pipe(
    //   debounceTime(800)
    // ).subscribe(value => {
    //   this.displayMessage = this.genericValidator.processMessages(this.productForm);
    // });
  }

  getCategory(id: number): void {
    this.categoryService.getBookCategoryById(id)
      .subscribe(
        (p: BookCategory) => this.displayCategory(p),
        (error: any) => this.errorMessage = <any>error
      );
  }

  displayCategory(pr: BookCategory): void {
    if (this.CategoryForm) {
      this.CategoryForm.reset();
    }
    this.category = pr;

    if (this.category.id === 0) {
      this.pageTitle = 'Add Category';
    } else {
      this.pageTitle = `Edit Book Category: ${this.category.name}`;
    }

    // Update the data on the form
    this.CategoryForm.patchValue({
      categoryName: this.category.name,
      categoryCode: this.category.code
    }); 
  }

  deleteCategory(): void {
    if (this.category.id === 0) {
      // Don't delete, it was never saved.
      this.onSaveComplete();
    } else {
      if (confirm(`Really delete the Category: ${this.category.name}?`)) {
        this.categoryService.deleteBookCategory(this.category.id)
          .subscribe(
            () => this.onSaveComplete(),
            (error: any) => this.errorMessage = <any>error
          );
      }
    }
  }

  saveCategory(): void {
    if (this.CategoryForm.valid) {
      if (this.CategoryForm.dirty) {
        const p = { ...this.category, ...this.CategoryForm.value };

        if (p.id === 0) {
          this.categoryService.createBookCategory(p)
            .subscribe(
              () => this.onSaveComplete(),
              (error: any) => this.errorMessage = <any>error
            );
        } else {
          this.categoryService.updateBookCategory(p)
            .subscribe(
              () => this.onSaveComplete(),
              (error: any) => this.errorMessage = <any>error
            );
        }
      } else {
        this.onSaveComplete();
      }
    } else {
      this.errorMessage = 'Please correct the validation errors.';
    }
  }

  onSaveComplete(): void {
    // Reset the form to clear the flags
    this.CategoryForm.reset();
    this.router.navigate(['/bookCategory']);
  }

}
