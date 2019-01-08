import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { BookCategoryService } from '../book-category.service';
import { BookCategory } from '../book-category';


@Component({
  selector: 'app-book-category-detail',
  templateUrl: './book-category-detail.component.html',
  styleUrls: ['./book-category-detail.component.css']
})
export class BookCategoryDetailComponent implements OnInit {

  errorMessage = '';
  pageTitle:"BM-Book Category Details";
  private bookCat :BookCategory;
  
  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private bookCategoryService: BookCategoryService) { }

  ngOnInit() {
      const param=this.route.snapshot.paramMap.get('id');
      if(param){
          const id=+param;
          this.getBookCategory(id)
      }

      
  }

  getBookCategory(id:number):void{
    this.bookCategoryService.getBookCategoryById(id).subscribe(
      r=>this.bookCat=r,
      error => this.errorMessage = <any>error
    )
  }
  onBack():void
  {
    this.router.navigate(['/bookCategory']);
  }

}
