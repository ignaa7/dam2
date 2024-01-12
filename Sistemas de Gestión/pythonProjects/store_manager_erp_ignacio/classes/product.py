class Product:
    def __init__(self, id, name, price, stock_quantity):
        self.id = id
        self.name = name
        self.price = price
        self.stock_quantity = stock_quantity
    
    def set_stock_quantity(self, stock_quantity):
        self.stock_quantity = stock_quantity

    def get_price(self):
        return self.price
    
    def to_string(self):
        return f"ID: {self.id}\nNombre: {self.name}\nPrecio: {self.price}\nCantidad en stock: {self.stock_quantity}"