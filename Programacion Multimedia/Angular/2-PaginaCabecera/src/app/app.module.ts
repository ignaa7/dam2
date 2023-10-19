import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HeaderComponentComponent } from './header-component/header-component.component';
import { Header2ComponentComponent } from './header2-component/header2-component.component';
import { Header3ComponentComponent } from './header3-component/header3-component.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponentComponent,
    Header2ComponentComponent,
    Header3ComponentComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
