from classes.order import Order
from classes.store import Store


class Service:
    def __init__(self):
        self.orders = []
        self.store = Store()

    def add_product(self, name, price, stock_quantity):
        self.store.add_product(name, price, stock_quantity)
    
    def add_order(self, products):
        order = Order(products, self.store)
        self.orders.append(order)

        return order.calculate_total_price()
    
    def get_products(self):
        return self.store.get_products()