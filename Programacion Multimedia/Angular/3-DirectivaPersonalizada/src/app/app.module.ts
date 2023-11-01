import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { DirectivaADirective } from './directivas/directiva-a/directiva-a.directive';
import { DirectivaAParametrizadaDirective } from './directivas/directiva-a-parametrizada/directiva-a-parametrizada.directive';

@NgModule({
  declarations: [
    AppComponent,
    DirectivaADirective,
    DirectivaAParametrizadaDirective
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
