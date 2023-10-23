using Ejercicio7.Banco;
using Ejercicio7.HerenciaPersona;
using Ejercicio7.JuegoDados;
using Ejercicio7.Triangulo;

Console.OutputEncoding = System.Text.Encoding.UTF8;

//1
Triangulo triangulo = new(10, 5);
Console.WriteLine($"Longitud lados iguales: {triangulo.LongitudLadosIguales}u");
Console.WriteLine($"Longitud lado distinto: {triangulo.LongitudLadoDistinto}u");
Console.WriteLine($"Perímetro: {triangulo.CalcularPerimetro()}u");
Console.WriteLine($"Área: {triangulo.CalcularArea()}u²");
Console.WriteLine();


//2
var juego = Juego.Jugar();
Console.WriteLine($"Dado 1: {juego.dado1}\nDado 2:{juego.dado2}\nDado 3: {juego.dado3}\n{juego.mensaje}");
Console.WriteLine();


//3
Banco.Operar("12345678G", Banco.Operaciones.Ingresar, 100.8);
Banco.Operar("75847362H", Banco.Operaciones.Extraer, 23.1);
Console.WriteLine($"Dinero al final del día: {Banco.CalcularDinero()}€");
Console.WriteLine();


//4
Persona persona = new Persona("Alba", 21);
Empleado empleado = new Empleado("Godofredo", 44, 1000);
Console.WriteLine($"Persona:\n{persona.toString()}\n\nEmpleado:\n{empleado.toString()}\nSueldo: {empleado.getSueldo()}€");