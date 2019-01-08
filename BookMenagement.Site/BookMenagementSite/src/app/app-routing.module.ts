import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { WelcomeComponent } from './welcome/welcome.component';



import { BookCategoryListComponent } from './book-category/book-category-list/book-category-list.component';
import { BookCategoryDetailComponent } from './book-category/book-category-detail/book-category-detail.component';
import { BookCategoryEditComponent } from './book-category/book-category-edit/book-category-edit.component';

const routes: Routes = [
   
  { path: 'welcome', component: WelcomeComponent },
  
  {path:'bookCategory',component:BookCategoryListComponent},
  {path:'bookCategory/:id',component:BookCategoryDetailComponent},
  {path:'bookCategory/:id/edit',component:BookCategoryEditComponent},

   { path: '', redirectTo: 'welcome', pathMatch: 'full' },
   { path: '**', redirectTo: 'welcome', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
