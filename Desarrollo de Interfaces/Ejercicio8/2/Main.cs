using _2;

Electrodomestico[] electrodomesticos = { new Lavadora(), new Television(), new Lavadora(100, 100), new Television(200, 50), new Lavadora(), new Television(), new Lavadora(), new Lavadora(), new Television(), new Lavadora()};

double sumaPreciosLavadoras = 0;
double sumaPreciosTelevisiones = 0;
double sumaPreciosElectrodomesticos = 0;

foreach (Electrodomestico electrodomestico in electrodomesticos)
{
    if (electrodomestico is  Lavadora)
    {
        sumaPreciosLavadoras += electrodomestico.PrecioFinal();
    }
    else if (electrodomestico is Television)
    {
        sumaPreciosTelevisiones += electrodomestico.PrecioFinal();
    }

    sumaPreciosElectrodomesticos += electrodomestico.PrecioFinal();
}

Console.WriteLine($"Precio lavadoras: {sumaPreciosLavadoras}");
Console.WriteLine($"Precio televisiones: {sumaPreciosTelevisiones}");
Console.WriteLine($"Precio electrodomésticos: {sumaPreciosElectrodomesticos}");