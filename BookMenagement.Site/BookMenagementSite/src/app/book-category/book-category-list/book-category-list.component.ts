import { Component, OnInit } from '@angular/core';

import { BookCategory } from 'src/app/models/book-category';
import { BookCategoryService } from 'src/app/services/book-category.service';


@Component({
  selector: 'app-book-category-list',
  templateUrl: './book-category-list.component.html',
  styleUrls: ['./book-category-list.component.css']
})
export class BookCategoryListComponent implements OnInit {
  errorMessage = '';
  pageTitle:"BM-Book Category ";
  constructor(private bookCategoryService: BookCategoryService) { }
  
  list:BookCategory[];
  filteredList:BookCategory[];

  ngOnInit() {
    this.bookCategoryService.getBookCategory().subscribe(
      p => {
        this.list = p;
        this.filteredList = this.list;
      },
      error => this.errorMessage = <any>error
    );
  }

}
