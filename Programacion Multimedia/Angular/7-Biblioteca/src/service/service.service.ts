import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, Subject } from 'rxjs';
import { Book } from 'src/classes/book/book';

@Injectable({
  providedIn: 'root'
})
export class Service {

  //properties

  private _books : Book[];
  private _subject: BehaviorSubject<Object[]>;

  constructor() { 
    this._books = [];

    this._books.push(new Book("El corredor del laberinto", "James Dashner", "1", new Date(2010,7, 24)));
    this._books.push(new Book("Los juegos del hambre", "Suzanne Collins", "2", new Date(2008, 8, 14)));
    this._books.push(new Book("Percy Jackson", "Rick Riordan", "3", new Date(2005,5,28)));

    this._subject = new BehaviorSubject<Object[]>(this.books);
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
    let filteredBooks: Book[] = this._books.filter(book => book.title.includes(filter));
    this._subject.next(this.getBooksCopy(filteredBooks));
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
