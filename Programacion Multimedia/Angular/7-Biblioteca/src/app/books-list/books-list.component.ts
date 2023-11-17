import { Component } from '@angular/core';
import { Book } from 'src/classes/book/book';
import { Service } from 'src/service/service.service';

@Component({
  selector: 'books-list',
  templateUrl: './books-list.component.html',
  styleUrls: ['./books-list.component.css']
})
export class BooksListComponent {
  books: any[];

  constructor(private service: Service) {
    this.books = service.books;

    this.service.subject.subscribe(books => this.books = books);
  }
}