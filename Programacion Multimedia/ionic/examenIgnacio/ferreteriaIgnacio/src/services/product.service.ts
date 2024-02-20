import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { Product } from 'src/models/product';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private _products: Product[];
    private _subject: BehaviorSubject<Product[]>;

    constructor() {
        this._products = [
            new Product('Producto 1', 22),
            new Product('Producto 2', 10),
            new Product('Producto 3', 33),
            new Product('Producto 4', 40),
            new Product('Producto 5', 1)
        ];

        this._subject = new BehaviorSubject<Product[]>(this._products);
    }

    public getObservable(): Observable<Product[]> {
      return this._subject.asObservable();
    }

    public filterProducts(filter: string) : void {
      if (filter === 'all') {
        this._subject.next(this._products);
      } else if (filter === 'bought') {
        this._subject.next(this._products.filter(product => product.isInShoppingCart));
      }
    }

    public addToShoppingCart(product: Product) : void {
      product.isInShoppingCart = true;
      product.quantity = product.quantity++;
      
      this.filterProducts('all');
    }

    public modifyProductQuantity(product: Product, operation: string)  : void{
      if (operation === '+') {
        product.quantity++;
      } else if (operation === '-') {
        product.quantity--;
      }
      
      this.filterProducts('bought');
    }

    public buyProducts() : number {
      let totalPrice: number = 0;

      this._products.forEach(product => {
        totalPrice += product.quantity * product.price;
      });

      return totalPrice;
    }
}
