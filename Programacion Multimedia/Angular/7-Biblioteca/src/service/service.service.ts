import { Injectable } from '@angular/core';
import { Observable, Subject } from 'rxjs';
import { Book } from 'src/classes/book/book';

@Injectable({
  providedIn: 'root'
})
export class Service {

  //properties

  private _books : Book[];
  private _subject: Subject<Object[]>;

  constructor() { 
    this._books = [];
    this._subject = new Subject<Object[]>();
  }

  //getters

  public get subject(): Observable<Object[]> {
    return this._subject.asObservable();
  }

  public get books(): Object[] {
    return this.getBooksCopy(this._books);
  }

  //methods

  public getFilteredBooks(filter: string): void {
    this._subject.next(this.getBooksCopy(this._books.filter(book => book.title.includes(filter))));
  }

  private getBooksCopy(books : Book[]): Object[] {
    let booksCopy : Object[] = [];
    
    books.forEach(book => {
      booksCopy.push({
        title: book.title,
        author: book.author,
        isbn: book.isbn,
        date: book.date
      })
    });
    return booksCopy;
  }
}
