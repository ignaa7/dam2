import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { TuberiaPipe } from './tuberias/tuberia/tuberia.pipe';

@NgModule({
  declarations: [
    AppComponent,
    TuberiaPipe
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
