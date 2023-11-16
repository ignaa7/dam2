import { Injectable } from '@angular/core';
import { Book } from 'src/classes/book/book';

//inyectar en los dos componentes
@Injectable({
  providedIn: 'root'
})
export class Service {
  private books : Book[];

  constructor() { 
    this.books = [];
  }

  public getBooks() {
    return this.getBooksCopy(this.books);
  }

  private getBooksCopy(books : Book[]): Object[] {
    let booksCopy : Object[] = [];
    
    this.books.forEach(book => {
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
