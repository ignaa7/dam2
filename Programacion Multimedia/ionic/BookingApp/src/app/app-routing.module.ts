import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';
import { authGuard } from 'src/guards/auth-guard/auth.guard';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'main/discover',
    pathMatch: 'full'
  },
  {
    path: 'main',
    loadChildren: () => import('./main-page/main/main.module').then( m => m.MainPageModule),
    canMatch: [authGuard],
  },
  {
    path: 'auth',
    loadChildren: () => import('./auth-page/auth/auth.module').then( m => m.AuthPageModule),
  },
  {
    path: 'bookings',
    loadChildren: () => import('./bookings-page/bookings/bookings.module').then( m => m.BookingsPageModule),
    canMatch: [authGuard],
  }


];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
