import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginPageComponent } from './login-page/login-page.component';
import { SignupPageComponent } from './signup-page/signup-page/signup-page.component';

const routes: Routes = [
  { path: 'loginPage', component: LoginPageComponent },
  { path: 'signupPage', component: SignupPageComponent },
  // { 
  //   path: 'signupPage',
  //   component: SignupPageComponent,
  //   canActivate: [authenticationGuard]
  //  },
  { path: '', redirectTo: '/loginPage', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
