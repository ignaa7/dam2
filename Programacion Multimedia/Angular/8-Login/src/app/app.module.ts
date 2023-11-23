import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginPageComponent } from './login-page/login-page.component';
import { LoggedPageComponent } from './logged-page/logged-page.component';
import { FormsModule } from '@angular/forms';
import { AuthenticationService } from 'src/services/authentication-service/authentication-service.service';

@NgModule({
  declarations: [
    AppComponent,
    LoginPageComponent,
    LoggedPageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [
    AuthenticationService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
