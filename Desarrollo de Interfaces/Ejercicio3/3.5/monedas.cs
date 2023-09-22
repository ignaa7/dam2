double precioIntroducido;
int numMonedas5cts = 0;
int numMonedas10cts = 0;
int numMonedas20cts = 0;
int numMonedas50cts = 0;
int numMonedas1euro = 0;
int numMonedas2euros = 0;

Console.WriteLine("Introduzca la cantidad introducida en euros");
precioIntroducido = Convert.ToDouble(Console.ReadLine()) * 100;

if (precioIntroducido < 45) Console.WriteLine("El precio introducido debe ser mayor a 45 céntimos");
else
{
    precioIntroducido -= 45;

    while (precioIntroducido > 5)
    {
        if (precioIntroducido >= 200)
        {
            precioIntroducido -= 200;
            numMonedas2euros++;
        }
        else if (precioIntroducido >= 100)
        {
            precioIntroducido -= 100;
            numMonedas1euro++;
        }
        else if (precioIntroducido >= 50)
        {
            precioIntroducido -= 50;
            numMonedas50cts++;
        }
        else if (precioIntroducido >= 20)
        {
            precioIntroducido -= 20;
            numMonedas20cts++;
        }
        else if (precioIntroducido >= 10)
        {
            precioIntroducido -= 10;
            numMonedas10cts++;
        }
        else if (precioIntroducido >= 5)
        {
            precioIntroducido -= 5;
            numMonedas5cts++;
        }
    }

    Console.WriteLine("Monedas devueltas: \nMonedas de 2\u20AC: " + numMonedas2euros + "\nMonedas de 1\u20AC: " + numMonedas1euro + "\nMonedas de 50cts: " + numMonedas50cts + "\nMonedas 20cts: " + numMonedas20cts + "\nMonedas 10cts: " + numMonedas10cts + "\nMonedas 5cts: " + numMonedas5cts);
}