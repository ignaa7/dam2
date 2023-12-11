import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PadreComponent } from './padre/padre.component';
import { Hijo2Component } from './hijo2/hijo2.component';
import { guard } from './guard/guard.guard';
import { Hijo3Component } from './hijo3/hijo3.component';

const routes: Routes = [
  {path: 'padre', component: PadreComponent},
  {path: 'hijo2', component: Hijo2Component, canActivate: [guard]},
  {path: 'hijo3', component: Hijo3Component},
  {path: '', redirectTo: '/padre', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }