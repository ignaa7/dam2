import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { DiscoverPage } from './discover.page';
import { authGuard } from 'src/guards/auth-guard/auth.guard';

const routes: Routes = [
  {
    path: '',
    component: DiscoverPage
  },
  {
    path: ':placeId',
    loadChildren: () => import('./place-details-page/place-details/place-details.module').then( m => m.PlaceDetailsPageModule),
    canMatch: [authGuard],
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class DiscoverPageRoutingModule {}
