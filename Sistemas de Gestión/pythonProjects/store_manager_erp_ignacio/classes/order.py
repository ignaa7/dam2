from datetime import date


class Order:
    def __init__(self, products):
        self.date = date.today()
        self.products = products  # dictionary {name: quantity}
    
    def calculate_total_price(self):
        total_price = 0

        for product in self.products:
            total_price += product.get_price() * self.products[product]