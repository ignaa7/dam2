import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { FiltersPanelComponent } from './filters-panel/filters-panel.component';
import { BooksListComponent } from './books-list/books-list.component';

@NgModule({
  declarations: [
    AppComponent,
    FiltersPanelComponent,
    BooksListComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
