using Ejercicio2;

Console.WriteLine("Número de empleados:");
int numeroEmpleados = Int32.Parse(Console.ReadLine());

Empleado[] empleados = new Empleado[numeroEmpleados];

try
{
    for (int i = 0; i < numeroEmpleados; i++)
    {
        Console.WriteLine($"DNI empleado {i+1}:");
        string dni = Console.ReadLine();
        empleados[i] = new Empleado(dni);
    }
}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
    throw exception;
}

Console.WriteLine();
Console.WriteLine("Empleado con mayor sueldo:");
Empleado empleadoMayorSueldo = empleados.MaxBy(empleado => empleado.CalcularSueldoNeto());
Console.WriteLine(empleadoMayorSueldo.ToString());

Console.WriteLine();
Console.WriteLine("Empleados con hijos:");
var empleadosConHijos = empleados.Where(empleado => empleado.NumeroHijos > 0);
foreach(Empleado empleado in empleadosConHijos)
{
    Console.WriteLine(empleado.ToString());
}

Console.WriteLine();
Console.WriteLine("Empleados ordenados por salario de menor a mayor:");
var empleadosOrdenados = empleados.OrderByDescending(empleado => empleado.CalcularSueldoNeto());
foreach (Empleado empleado in empleadosOrdenados)
{
    Console.WriteLine(empleado.ToString());
}