import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginPageComponent } from './login-page/login-page.component';
import { SignupPageComponent } from './signup-page/signup-page/signup-page.component';
import { authGuard } from './auth-guard/auth.guard';
import { GameComponent } from './game-page/game-component/game/game.component';

const routes: Routes = [
  { path: 'loginPage', component: LoginPageComponent },
  { path: 'signupPage', component: SignupPageComponent },
  { 
    path: 'gamePage',
    component: GameComponent,
    canActivate: [authGuard]
   },
  { path: '', redirectTo: '/loginPage', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
