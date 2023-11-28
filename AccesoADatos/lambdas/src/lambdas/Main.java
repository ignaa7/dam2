package lambdas;

public class Main {

	public static void main(String[] args) {
		// 1
		InterfazFuncional mediaEnteros = (int... numeros) -> {
			if (numeros.length == 0) {
                return 0;
            }

            int suma = 0;
            
            for (int numero : numeros) {
                suma += numero;
            }

            return (double) suma / numeros.length;
		};
		
		System.out.println(mediaEnteros.calcular(1, 2, 3, 4));
		
		
		// 2
		InterfazFuncional factorial = (int... numeros) -> {
			int factorialNumero = 1;
			
            for (int numero = numeros[0]; numero > 1; numero--) {
                factorialNumero *= numero;
            }

            return factorialNumero;
		};
		
		System.out.println(factorial.calcular(4));
		
		
		// 3
		InterfazFuncional numeroPar = (int... numeros) -> numeros[0] % 2 == 0;
		
		System.out.println(numeroPar.calcular(3));
		
		
		// 4
		InterfazFuncional numeroMayor = (int... numeros) -> {
			if (numeros.length == 0) {
                return 0;
            }

            int suma = 0;
            
            for (int numero : numeros) {
                suma += numero;
            }

            return (double) suma / numeros.length;
		};
		
		System.out.println(mediaEnteros.calcular(1, 2, 3, 4));
	}

}
