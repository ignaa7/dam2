import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { OfferDetailsPage } from './offer-details.page';
import { authGuard } from 'src/guards/auth-guard/auth.guard';

const routes: Routes = [
  {
    path: '',
    component: OfferDetailsPage
  },
  {
    path: 'edit/:placeId',
    loadChildren: () => import('./edit-offer-page/edit-offer/edit-offer.module').then( m => m.EditOfferPageModule),
    canMatch: [authGuard],
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class OfferDetailsPageRoutingModule {}
