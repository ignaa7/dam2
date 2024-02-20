import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from 'src/models/product';
import { ProductService } from 'src/services/product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.page.html',
  styleUrls: ['./products.page.scss'],
})
export class ProductsPage implements OnInit {
  public observable: Observable<Product[]>;

  constructor(private productService: ProductService) {
    this.observable = productService.getObservable();
   }

   public addToShoppingCart(product: Product) {
    this.productService.addToShoppingCart(product);
   }

  ngOnInit() {
  }

  ionWillEnter() {
    this.productService.filterProducts('all');
  }

}
