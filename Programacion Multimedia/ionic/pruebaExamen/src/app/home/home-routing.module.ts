import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomePage } from './home.page';

const routes: Routes = [
  {
    path: '',
    component: HomePage,
    children:[
      {
        path: 'child',
        loadChildren: () => import('./child/child.module').then( m => m.ChildPageModule)
      },
      {
        path: 'child2',
        loadChildren: () => import('./child2/child2.module').then( m => m.Child2PageModule)
      },
    ]
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomePageRoutingModule {}
