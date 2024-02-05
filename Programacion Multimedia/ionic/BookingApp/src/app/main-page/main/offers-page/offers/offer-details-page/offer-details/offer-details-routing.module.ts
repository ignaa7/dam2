import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { OfferDetailsPage } from './offer-details.page';

const routes: Routes = [
  {
    path: '',
    component: OfferDetailsPage
  },
  {
    path: 'edit/:placeId',
    loadChildren: () => import('./edit-offer-page/edit-offer/edit-offer.module').then( m => m.EditOfferPageModule)
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class OfferDetailsPageRoutingModule {}
