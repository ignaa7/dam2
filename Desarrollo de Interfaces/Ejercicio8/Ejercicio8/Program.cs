using Ejercicio8;

CuentaBancaria cuentaBancaria = new CuentaBancaria();
CuentaEmpresarial cuentaEmpresarial =  new CuentaEmpresarial();

cuentaBancaria.Operar(CuentaBancaria.Operaciones.Ingresar, 100);
cuentaEmpresarial.Operar(CuentaBancaria.Operaciones.Ingresar, 1000);
Console.WriteLine($"Cuenta Bancaria: {cuentaBancaria.MostrarSaldo()}");
Console.WriteLine($"Cuenta Empresarial: {cuentaEmpresarial.MostrarSaldo()}");

cuentaEmpresarial.RealizarTransferencia(cuentaBancaria, 2000);
cuentaEmpresarial.RealizarTransferencia(cuentaBancaria, 1000);
Console.WriteLine($"Cuenta Bancaria: {cuentaBancaria.MostrarSaldo()}");
Console.WriteLine($"Cuenta Empresarial: {cuentaEmpresarial.MostrarSaldo()}");