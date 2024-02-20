import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';

const routes: Routes = [
  {
    path: '',
    component: AppComponent,
    children:[
      {
        path: 'products',
        loadChildren: () => import('./products/products.module').then( m => m.ProductsPageModule)
      },
      {
        path: 'shopping-cart',
        loadChildren: () => import('./shopping-cart/shopping-cart.module').then( m => m.ShoppingCartPageModule)
      },
    ]
  },
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
