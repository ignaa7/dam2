from store_manager_erp.classes.product import Product


class Store:
    def __init__(self):
        self.products = {
            1: Product(1, "Manzana", 0.65, 100),
            2: Product(2, "Patata", 1.1, 55),
            3: Product(3, "Plátano", 0.99, 80),
            4: Product(4, "Rábano", 0.87, 44)
        }
    
    def add_product(self, name, price, stock_quantity):
        id = len(self.products) + 1
        self.products[id] = Product(id, name, price, stock_quantity)
    
    def get_products(self):
        return self.products