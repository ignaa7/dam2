using Ejercicio2;

Servicio servicio = new Servicio();

Console.WriteLine("Introduzca el número total de productos perecederos");

int numProductos = 0;

try
{
    numProductos = Convert.ToInt32(Console.ReadLine());
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

string codigo = default!;
string nombre = default!;
double precio = default;
int dias = default;

for (int i = 0; i < numProductos; i++)
{
    Console.WriteLine("Código");
    codigo = Console.ReadLine();
    Console.WriteLine("Nombre");
    nombre = Console.ReadLine();
    Console.WriteLine("Precio");
    precio = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Días a caducar");
    dias = Convert.ToInt32(Console.ReadLine());

    servicio.agregarProducto(new ProductoPerecedero(dias, codigo, nombre, precio));
}


Console.WriteLine("Introduzca el número total de productos no perecederos");

numProductos = 0;

try
{
    numProductos = Convert.ToInt32(Console.ReadLine());
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

codigo = default!;
nombre = default!;
precio = default;
dias = default;

for (int i = 0; i < numProductos; i++)
{
    Console.WriteLine("Código");
    codigo = Console.ReadLine();
    Console.WriteLine("Nombre");
    nombre = Console.ReadLine();
    Console.WriteLine("Precio");
    precio = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Días a caducar");
    dias = Convert.ToInt32(Console.ReadLine());

    servicio.agregarProducto(new ProductoPerecedero(dias, codigo, nombre, precio));
}