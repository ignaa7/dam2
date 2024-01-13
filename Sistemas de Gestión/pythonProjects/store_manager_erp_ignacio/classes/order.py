from classes.store import Store
from datetime import date


class Order:
    def __init__(self, products, store):
        self.date = date.today()
        self.products = products  # dictionary {name: quantity}
        self.store = store
        store.update_products_stock(products)
    
    def calculate_total_price(self):
        total_price = 0

        for name, quantity in self.products.items():
            total_price += self.store.get_product_price(name) * quantity
        
        return total_price