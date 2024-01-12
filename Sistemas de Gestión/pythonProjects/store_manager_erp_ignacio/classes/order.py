from classes.store import Store
from datetime import date


class Order:
    def __init__(self, products):
        self.date = date.today()
        self.products = products  # dictionary {name: quantity}
        self.store = Store()
        self.update_stock()
    
    def update_stock(self):
        productsStored = self.store.get_products()

        for id, product in productsStored.items():
            for name, quantity in self.products.items():
                if product.get_name() == name:
                    product.set_stock_quantity(product.get_stock_quantity() - quantity)
            
    
    def calculate_total_price(self):
        total_price = 0

        for product in self.products:
            total_price += product.get_price() * self.products[product]