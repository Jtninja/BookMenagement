import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuthorListComponent } from '../author/author-list/author-list.component';
import { AuthorEditComponent } from '../author/author-edit/author-edit.component';
import { AuthorDetailsComponent } from '../author/author-details/author-details.component';
import { ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from '../app-routing.module';

@NgModule({
  declarations: [
              AuthorListComponent, 
              AuthorEditComponent,
               AuthorDetailsComponent
              ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    AppRoutingModule
  ]
})
export class AuthorModule { }
