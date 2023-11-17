import { Component } from '@angular/core';
import { Service } from 'src/service/service.service';

@Component({
  selector: 'books-list',
  templateUrl: './books-list.component.html',
  styleUrls: ['./books-list.component.css']
})
export class BooksListComponent {
  books: Object[];

  constructor(private service: Service) {}


  ngOnInit() {
    this.service.subject.subscribe( books => this.books = books );
  }
  }
}
