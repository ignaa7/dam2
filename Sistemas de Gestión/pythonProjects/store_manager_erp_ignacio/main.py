from service.service import Service

service = Service()
exit = False

while not exit:
    print("\n--- Menú ---") 
    print("1. Agregar Producto al Inventario") 
    print("2. Realizar Orden de Compra") 
    print("3. Mostrar Inventario") 
    print("4. Salir")

    option = int(input("Elija una opción: "))

    if option == 1:
        name = input("Nombre: ")
        price = int(input("Precio: "))
        stock_quantity = int(input("Cantidad en stock: "))

        service.add_product(name, price, stock_quantity)

        print("Producto añadido correctamente")
    
    elif option == 2:
        introduce_product = 's'
        products = {}

        while introduce_product == 's':
            name = input("Nombre del producto: ")
            quantity = input("Cantidad del producto: ")
            products[name] = int(quantity)
            introduce_product = input("¿Quiere introducir otro producto? s / n ")
        
        order_price = service.add_order(products)
        print(f"El precio total del pedido es {order_price}€")
    
    elif (option == 3):
        products = service.get_products()

        for id, product in products.items():
            print(product.to_string() + "\n")
    
    elif (option == 4):
        exit = True