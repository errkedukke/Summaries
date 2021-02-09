import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  _baseUrl: string = "api/Books";

  constructor(private http: HttpClient) { }

  getAllBooks()
  {
    return this.http.get<Book[]>(this._baseUrl);
  }

  addBook(book: Book)
  {
    return this.http.post(this._baseUrl, book);
  }
}
