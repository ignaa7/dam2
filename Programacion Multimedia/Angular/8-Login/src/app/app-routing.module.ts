import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginPageComponent } from './login-page/login-page.component';
import { LoggedPageComponent } from './logged-page/logged-page.component';
import { authenticationGuard } from './authentication-guard/authentication-guard.guard';

const routes: Routes = [
  { path: 'loginPage', component: LoginPageComponent },
  { 
    path: 'loggedPage',
    component: LoggedPageComponent,
    canActivate: [authenticationGuard]
   },
  { path: '', redirectTo: '/loginPage', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
