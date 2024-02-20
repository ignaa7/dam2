import { Component, OnInit } from '@angular/core';
import { Product } from 'src/models/product';
import { ProductService } from 'src/services/product.service';

@Component({
  selector: 'app-shopping-cart',
  templateUrl: './shopping-cart.page.html',
  styleUrls: ['./shopping-cart.page.scss'],
})
export class ShoppingCartPage implements OnInit {
  public alertButtons: any[] = [
    {
      text: 'Confirm',
      handler: this.buyProducts()
    },
    {
      text: 'Cancel',
      role: 'cancel'
    }
  ];

  constructor(private productService: ProductService) { }

  public buyProducts() {
    this.productService.buyProducts();
  }

  public modifyProductsQuantity(product: Product, operation: string) {}

  ngOnInit() {
  }

  ionWillEnter() {
    this.productService.filterProducts('bought');
  }

}
