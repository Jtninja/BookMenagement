import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { WelcomeComponent } from './welcome/welcome.component';
import { BookCategoryModule } from './book-category/book-category.module';
import { AuthorModule } from './author/author.module';



@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BookCategoryModule,
    AuthorModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
