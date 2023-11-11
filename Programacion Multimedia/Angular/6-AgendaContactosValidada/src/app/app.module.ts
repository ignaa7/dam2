import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { FormComponentComponent } from './form-component/form-component.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ContactoComponentComponent } from './contacto-component/contacto-component.component';
import { Service } from 'src/service/service.service';

@NgModule({
  declarations: [
    AppComponent,
    FormComponentComponent,
    ContactoComponentComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [Service],
  bootstrap: [AppComponent]
})
export class AppModule { }
