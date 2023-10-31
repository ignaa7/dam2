import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { DirectivaADirective } from './directivas/directiva-a/directiva-a.directive';

@NgModule({
  declarations: [
    AppComponent,
    DirectivaADirective
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
