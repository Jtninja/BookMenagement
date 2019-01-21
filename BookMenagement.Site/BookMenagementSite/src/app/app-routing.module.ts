import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { WelcomeComponent } from './welcome/welcome.component';



import { BookCategoryListComponent } from './book-category/book-category-list/book-category-list.component';
import { BookCategoryDetailComponent } from './book-category/book-category-detail/book-category-detail.component';
import { BookCategoryEditComponent } from './book-category/book-category-edit/book-category-edit.component';
import { AuthorListComponent } from './author/author-list/author-list.component';
import { AuthorDetailsComponent } from './author/author-details/author-details.component';
import { AuthorEditComponent } from './author/author-edit/author-edit.component';

const routes: Routes = [
   
  { path: 'welcome', component: WelcomeComponent },
  
  {path:'bookCategory',component:BookCategoryListComponent},
  {path:'bookCategory/:id',component:BookCategoryDetailComponent},
  {path:'bookCategory/:id/edit',component:BookCategoryEditComponent},
  {path:'author',component:AuthorListComponent},
  {path:'author/:id',component:AuthorDetailsComponent},
  {path:'author/:id/edit',component:AuthorEditComponent},

   { path: '', redirectTo: 'welcome', pathMatch: 'full' },
   { path: '**', redirectTo: 'welcome', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
