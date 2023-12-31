import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { FiltersPanelComponent } from './filters-panel/filters-panel.component';
import { BooksListComponent } from './books-list/books-list.component';
import { HeaderComponent } from './header/header/header.component';
import { Service } from 'src/service/service.service';

@NgModule({
  declarations: [
    AppComponent,
    FiltersPanelComponent,
    BooksListComponent,
    HeaderComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [Service],
  bootstrap: [AppComponent]
})
export class AppModule { }
