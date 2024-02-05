import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { OffersPage } from './offers.page';

const routes: Routes = [
  {
    path: '',
    component: OffersPage
  },
  {
    path: 'new',
    loadChildren: () => import('./new-offer-page/new-offer/new-offer.module').then( m => m.NewOfferPageModule)
  },
  {
    path: ':placeId',
    loadChildren: () => import('./offer-details-page/offer-details/offer-details.module').then( m => m.OfferDetailsPageModule)
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class OffersPageRoutingModule {}
