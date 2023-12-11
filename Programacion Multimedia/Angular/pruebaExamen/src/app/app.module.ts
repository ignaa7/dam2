import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HijoComponent } from './hijo/hijo.component';
import { DirectivaDirective } from './directiva/directiva.directive';
import { TuberiaPipe } from './tuberia/tuberia.pipe';
import { ReactiveFormsModule } from '@angular/forms';
import { Service } from 'src/services/service/service.service';
import { PadreComponent } from './padre/padre.component';
import { Hijo2Component } from './hijo2/hijo2.component';
import { Hijo3Component } from './hijo3/hijo3.component';

@NgModule({
  declarations: [
    AppComponent,
    HijoComponent,
    DirectivaDirective,
    TuberiaPipe,
    PadreComponent,
    Hijo2Component,
    Hijo3Component,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule
  ],
  providers: [
    Service
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
