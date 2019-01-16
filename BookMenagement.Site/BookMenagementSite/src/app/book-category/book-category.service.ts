import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable, of, throwError, never, empty } from 'rxjs';
import { catchError, tap, map } from 'rxjs/operators';

import {BookCategory} from './book-category'
import { environment } from 'src/environments/environment';
import { Router } from '@angular/router';


@Injectable({
  providedIn: 'root'
})
export class BookCategoryService {
  private bookCategoryServerUrl:string=environment.serverUrl+"/bookCategory";
  
  constructor(private http: HttpClient,private router: Router ) { } 
  
  getBookCategory(): Observable<BookCategory[]> {
    return this.http.get<BookCategory[]>(this.bookCategoryServerUrl)
      .pipe(
        tap(data => console.log(JSON.stringify(data))),
        catchError(this.handleError)
      );
  }

  getBookCategoryById(id: number): Observable<BookCategory> {
    if (id === 0) {
      return of(this.initializeObject());
    }
    const url = `${this.bookCategoryServerUrl}/${id}`;
    return this.http.get<BookCategory>(url)
      .pipe(
        tap(data => console.log('getProduct: ' + JSON.stringify(data))),
        catchError(this.handleError)
      );
  }

  
  createBookCategory(product: BookCategory): Observable<BookCategory> {
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    product.id = 0;
    return this.http.post<BookCategory>(this.bookCategoryServerUrl, product, { headers: headers })
      .pipe(
        tap(data => console.log('createProduct: ' + JSON.stringify(data))),
        catchError(this.handleError)
      );
  }

  updateBookCategory(product: BookCategory): Observable<BookCategory> {
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    return this.http.put<BookCategory>(this.bookCategoryServerUrl, product, { headers: headers })
      .pipe(
        tap(data => console.log('updateProduct: ' + JSON.stringify(data))),
        catchError(this.handleError)
      );
  }

  deleteBookCategory(id: number): Observable<{}> {
    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    const url = `${this.bookCategoryServerUrl}/${id}`;
    return this.http.delete<BookCategory>(url, { headers: headers })
      .pipe(
        tap(data => console.log('deleteProduct: ' + id)),
       catchError(err=>this.handleErrorInDelete(err,"/bookCategory")
       ));
  }


  private handleError(err) {
    // in a real world app, we may send the server to some remote logging infrastructure
    // instead of just logging it to the console
    let errorMessage: string;
    if (err.error instanceof ErrorEvent) {
      // A client-side or network error occurred. Handle it accordingly.
      errorMessage = `An error occurred: ${err.error.message}`;
    } else {
      // The backend returned an unsuccessful response code.
      // The response body may contain clues as to what went wrong,
      errorMessage = `Backend returned code ${err.status}: ${err.error.Code}`;
    }
    console.error(err);
    return throwError(errorMessage);
  }
  private handleErrorInDelete(err:any,url:string): Observable<never> {
    if(err.status==404)
        {
          console.error(err);
          this.router.navigate([url]);
          return empty();
        }
    else
         return this.handleError(err);
      
  }

  private initializeObject(): BookCategory {
    // Return an initialized object
    return {
      id: 0,
      name:'',
      code:''
    };
  }

}
