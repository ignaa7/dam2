import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { MainPage } from './main.page';
import { authGuard } from 'src/guards/auth-guard/auth.guard';

const routes: Routes = [
  {
    path: '',
    component: MainPage,
    children: [
      {
        path: 'discover',
        loadChildren: () => import('./discover-page/discover/discover.module').then(m => m.DiscoverPageModule),
        canMatch: [authGuard],

      },
      {
        path: 'offers',
        loadChildren: () => import('./offers-page/offers/offers.module').then(m => m.OffersPageModule),
        canMatch: [authGuard],
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class MainPageRoutingModule { }
