import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Book } from './book';
import { Observable } from 'rxjs'; //for async requests


@Injectable({             //The book service is using an Injectable Decorator. 
  providedIn: 'root'      //we can use everywhere in our application. 
})
export class BookService {

  private apiUrl = 'https://localhost:7173';

  constructor(private http : HttpClient) { }

  getBooks(): Observable<Book[]>{
    return this.http.get<Book[]>(this.apiUrl);
  }
}
