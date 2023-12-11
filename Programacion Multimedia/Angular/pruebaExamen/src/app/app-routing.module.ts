import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PadreComponent } from './padre/padre.component';
import { Hijo2Component } from './hijo2/hijo2.component';
import { guard } from './guard/guard.guard';

const routes: Routes = [
  {path: 'padre', component: PadreComponent},
  {path: 'hijo2', component: Hijo2Component, canActivate: [guard]},
  {path: '', redirectTo: '/padre', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
