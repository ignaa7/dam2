import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { Book } from 'src/classes/book/book';
import { Service } from 'src/service/service.service';

@Component({
  selector: 'books-list',
  templateUrl: './books-list.component.html',
  styleUrls: ['./books-list.component.css']
})
export class BooksListComponent {
  books: any[];
  observable: Observable<any[]>;

  constructor(private service: Service) {
    this.books = service.books;

    this.observable = this.service.subject;
  }
}