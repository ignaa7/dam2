//1
using Ejercicio6b;

int[] enteros = Enumerable.Range(1, 100).ToArray();

enteros = enteros.Where(numero => numero % 7 == 0).ToArray();

var numerosAgrupados = enteros.GroupBy(numero => numero % 2 == 0);

foreach (var grupo in numerosAgrupados)
{
    if (grupo.Key)
    {
        Console.Write("Par: ");
    }
    else
    {
        Console.Write("Impar: ");
    }

    foreach (var numero in grupo)
    {
        Console.Write(numero + " ");
    }
    Console.WriteLine();
}


//2
var Libros = new List<Libro>()
{
    new Libro("Don Quijote de la Mancha", 1, 1605, 500),
    new Libro("Historia de dos ciudades", 2, 1859, 200),
    new Libro("El Señor de los Anillos", 3, 1978, 150),
    new Libro("El principito", 4, 1951, 140),
    new Libro("El hobbit", 3, 1982, 100),
    new Libro("Sueño en el pabellón rojo", 5, 1792, 100),
    new Libro("Las aventuras de Alicia en el país de las maravillas", 6, 1865, 100),
    new Libro("Diez negritos", 7, 1939, 100),
    new Libro("El león, la bruja y el armario", 8, 1950, 85),
    new Libro("El código Da Vinci", 9, 2003, 80),
    new Libro("El guardián entre el centeno", 10, 1951, 65),
    new Libro("El alquimista", 11, 1988, 65),
};

var Autores = new List<Autor>()
{
    new Autor(1, "Miguel de Cervantes"),
    new Autor(2, "Charles Dickens"),
    new Autor(3, "J. R. R. Tolkien"),
    new Autor(4, "Antoine de Saint-Exupéry"),
    new Autor(5, "Cao Xueqin"),
    new Autor(6, "Lewis Car"),
    new Autor(7, "Agatha Christie"),
    new Autor(8, "C. S. Lewis"),
    new Autor(9, "Dan Brown"),
    new Autor(10, "J. D. Salinger"),
};
