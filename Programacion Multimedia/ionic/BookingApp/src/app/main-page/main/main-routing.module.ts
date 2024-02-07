import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { MainPage } from './main.page';

const routes: Routes = [
  {
    path: '',
    component: MainPage,
    children: [
      {
        path: 'bookings',
        loadChildren: () => import('./bookings-page/bookings/bookings.module').then( m => m.BookingsPageModule)
      },
      {
        path: 'discover',
        loadChildren: () => import('./discover-page/discover/discover.module').then( m => m.DiscoverPageModule)
      },
      {
        path: 'offers',
        loadChildren: () => import('./offers-page/offers/offers.module').then( m => m.OffersPageModule)
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class MainPageRoutingModule {}
