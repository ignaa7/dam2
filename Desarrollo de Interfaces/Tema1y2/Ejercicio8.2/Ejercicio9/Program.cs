using Ejercicio9;

//1. Definir la expresión regular para encontrar una fecha en formato dd/mm/yyyy
string fechaBien = "30/03/2001";
string fechaMal = "30/03/20012";
Console.WriteLine($"{fechaBien} -> {Servicio.comprobarFormatoFecha(fechaBien)}");
Console.WriteLine($"{fechaMal} -> {Servicio.comprobarFormatoFecha(fechaMal)}");
Console.WriteLine();

//2.Expresión regular para validar direcciones de correo electrónico
string correoBien = "correo_alguien@gmail.com";
string correoMal = "correo_alguien@@gmail.com";
Console.WriteLine($"{correoBien} -> {Servicio.comprobarFormatoCorreo(correoBien)}");
Console.WriteLine($"{correoMal} -> {Servicio.comprobarFormatoCorreo(correoMal)}");
Console.WriteLine();

//3. Expresión regular para extraer números de teléfono en formato ###-###-####
string telefonoBien = "648-299-7101";
string telefonoMal = "64-12-32";
Console.WriteLine($"{telefonoBien} -> {Servicio.comprobarFormatoTelefono(telefonoBien)}");
Console.WriteLine($"{telefonoMal} -> {Servicio.comprobarFormatoTelefono(telefonoMal)}");
Console.WriteLine();

//4. Expresión regular para validar una dirección IP
string ipBien = "255.255.255.0";
string ipMal = "2.5.2.";
Console.WriteLine($"{ipBien} -> {Servicio.comprobarFormatoIp(ipBien)}");
Console.WriteLine($"{ipMal} -> {Servicio.comprobarFormatoIp(ipMal)}");
Console.WriteLine();

//5. Expresión regular para validar una dirección MAC
string macBien = "A3:91:12:1B:34:A3";
string macMal = "A3:91:12:1B:34:A";
Console.WriteLine($"{macBien} -> {Servicio.comprobarFormatoMac(macBien)}");
Console.WriteLine($"{macMal} -> {Servicio.comprobarFormatoMac(macMal)}");
Console.WriteLine();

//6. Expresión regular para buscar palabras que comienzan con la letra especificada
string palabra = "Antes Patata Algo Algoritmo Venezuela Alcaparra Zapato";
char letra = 'A';
Console.WriteLine($"{palabra}, {letra} -> {Servicio.buscarPalabrasPorLetra(palabra, letra)}");
Console.WriteLine();