using _4_genericos;

void main()
{
    bool[] array = { true, false, false, true, false };
    double[] array2 = { 1.2, 3.14, 5.55, 10 };

    bool[] copiaArray = Servicio.crearCopiaArrayGenerico(array);
    foreach (bool copia in copiaArray)
    {
        Console.Write(copia + " ");
    }

    double[] copiaArray2 = Servicio.crearCopiaArrayGenerico(array2);
    foreach (double copia in copiaArray2)
    {
        Console.Write(copia + " ");
    }
}