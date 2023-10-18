package pruebaSocketsServidor;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;

public class Ejemplo2Servidor {
	public static void main(String[] arg) throws IOException {
		int numeroPuerto = 6000;// Puerto
		ServerSocket servidor = new ServerSocket(numeroPuerto);
		String cad = "";
		System.out.println("Esperando conexión...");
		Socket clienteConectado = servidor.accept();
		System.out.println("Cliente conectado...");
		// CREO FLUJO DE SALIDA AL CLIENTE
		PrintWriter fsalida = new PrintWriter(clienteConectado.getOutputStream(), true);
		// CREO FLUJO DE ENTRADA DEL CLIENTE
		BufferedReader fentrada = new BufferedReader(new InputStreamReader(clienteConectado.getInputStream()));
		while ((cad = fentrada.readLine()) != null)// recibo cad del cliente
		{
			fsalida.println(cad); // envió cadena al cliente
			System.out.println("Recibiendo: " + cad);
			if (cad.equals("*"))
				break;
		}
		// CERRAR STREAMS Y SOCKETS
		System.out.println("Cerrando conexión...");
		fentrada.close();
		fsalida.close();
		clienteConectado.close();
		servidor.close();
	}
}
