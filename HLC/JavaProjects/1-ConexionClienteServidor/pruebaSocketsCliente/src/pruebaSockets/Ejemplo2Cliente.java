package pruebaSockets;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;

public class Ejemplo2Cliente {
	public static void main(String[] args) throws IOException {
		String Host = "localhost";
		int Puerto = 6000;// puerto remoto
		Socket servidor = new Socket(Host, Puerto);
		// CREO FLUJO DE SALIDA AL SERVIDOR
		PrintWriter fsalida = new PrintWriter(servidor.getOutputStream(), true);
		// CREO FLUJO DE ENTRADA AL SERVIDOR
		BufferedReader fentrada = new BufferedReader(new InputStreamReader(servidor.getInputStream()));

		// FLUJO PARA ENTRADA ESTANDAR
		BufferedReader in = new BufferedReader(new InputStreamReader(System.in));

		String cadena, eco = "";
		System.out.print("Introduce cadena: ");
		cadena = in.readLine();// lectura por teclado
		while (cadena != null) {

			fsalida.println(cadena); // envió cadena al servidor
			eco = fentrada.readLine(); // recibo cadena del servidor
			System.out.println(" =>ECO: " + eco);
			System.out.print("Introduce cadena: ");
			cadena = in.readLine();// lectura por teclado

		}
		fsalida.close();
		fentrada.close();
		System.out.println("Fin del envío... ");
		in.close();
		servidor.close();
	}
}
