from service.service import Service


service = Service()
exit = False

while not exit:
    print("\n--- Menú ---") 
    print("1. Agregar Producto al Inventario") 
    print("2. Realizar Orden de Compra") 
    print("3. Mostrar Inventario") 
    print("4. Salir")

    option = input("Elija una opción: ")

    if (option == 1):
        name = input("Nombre: ")
        price = input("Precio: ")
        stock_quantity = input("Cantidad en stock: ")

        service.add_product(name, price, stock_quantity)

        print("Producto añadido correctamente")
    
    if (option == 2):
        introduce_product = 's'
        products = {}

        while introduce_product == 's':
            name = input("Nombre del producto: ")
            quantity = input("Cantidad del producto: ")
            products[name] = quantity
            introduce_product = input("¿Quiere introducir otro producto? s / n")
        
        service.add_order(products)
    
    if (option == 3):
        print(service.get_products())
    
    if (option == 4):
        exit = True