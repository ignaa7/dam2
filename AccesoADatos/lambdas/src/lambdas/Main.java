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
                return null;
            }

            int mayor = numeros[0];
            
            for (int numero : numeros) {
                if (numero > mayor) mayor = numero;
            }

            return mayor;
		};
		
		Object mayor = numeroMayor.calcular();
		
		if (mayor == null) {
			System.out.println("No ha introducido ningún número");
		} else {
			System.out.println(mayor);
		}
		
		
		// 5
		InterfazFuncional numeroMenor = (int... numeros) -> {
			if (numeros.length == 0) {
                return null;
            }

            int menor = numeros[0];
            
            for (int numero : numeros) {
                if (numero < menor) menor = numero;
            }

            return menor;
		};
		
		Object menor = numeroMayor.calcular();
		
		if (menor == null) {
			System.out.println("No ha introducido ningún número");
		} else {
			System.out.println(menor);
		}
		
		
		// 6
		InterfazFuncional moda = (int... numeros) -> {
			if (numeros.length == 0) {
                return null;
            }

            int numeroModa = 0;
            int contNumeroModa = 0;
            
            for (int numero : numeros) {
                int cont = 0;
                
                for (int numeroBucle : numeros) {
                	if (numeroBucle == numero) cont++;
                }
                
                if (cont > contNumeroModa) {
                	numeroModa = numero;
                	contNumeroModa = cont;
                }
            }

            return numeroModa;
		};
		
		Object numeroModa = moda.calcular();
		
		if (numeroModa == null) {
			System.out.println("No ha introducido ningún número");
		} else {
			System.out.println(moda);
		}
		
		
		// 7
		InterfazFuncionalMayor numeroMayorEntre3 = (int num1, int num2, int num3) -> {
			int numMayor = num1;			
            
            if (num2 > numMayor) numMayor = num2;
            if (num3 > numMayor) numMayor = num3;

            return numMayor;
		};
		
		int numMayor = numeroMayorEntre3(1, 2, 3);
		
		System.out.println(numMayor);
	}

}
