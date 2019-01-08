import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import {ReactiveFormsModule} from '@angular/forms'

import { AppRoutingModule } from '../app-routing.module';
import { BookCategoryListComponent } from './book-category-list/book-category-list.component';
import { BookCategoryDetailComponent } from './book-category-detail/book-category-detail.component';
import { BookCategoryEditComponent } from './book-category-edit/book-category-edit.component';
import { from } from 'rxjs';



@NgModule({
  declarations: [
    BookCategoryListComponent,
    BookCategoryDetailComponent,
    BookCategoryEditComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    AppRoutingModule
  ]
})
export class BookCategoryModule { }
