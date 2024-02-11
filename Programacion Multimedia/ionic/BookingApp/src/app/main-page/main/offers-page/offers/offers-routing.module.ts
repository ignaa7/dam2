import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { OffersPage } from './offers.page';
import { authGuard } from 'src/guards/auth-guard/auth.guard';

const routes: Routes = [
  {
    path: '',
    component: OffersPage
  },
  {
    path: 'new',
    loadChildren: () => import('./new-offer-page/new-offer/new-offer.module').then(m => m.NewOfferPageModule),
    canMatch: [authGuard],
  },
  {
    path: ':placeId',
    loadChildren: () => import('./offer-details-page/offer-details/offer-details.module').then(m => m.OfferDetailsPageModule),
    canMatch: [authGuard],
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class OffersPageRoutingModule { }
