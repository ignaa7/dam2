int[] numeros = Enumerable.Range(1, 20).ToArray();

var numerosPares = numeros.Where(numero => numero % 2 == 0).ToArray();

foreach (var numero in numerosPares)
{
    Console.Write(numero + " ");
}


Console.WriteLine();

Console.WriteLine(numeros.FirstOrDefault(numero => numero > 5));


int[] numerosInvertidos = numeros.OrderByDescending(numero => numero).ToArray();

foreach (var numero in numerosInvertidos)
{
    Console.Write(numero + " ");
}

//Anónimos
//var nombresYEdades = personas.Select(p => new { Nombre = p.Nombre, Edad = p.Edad });