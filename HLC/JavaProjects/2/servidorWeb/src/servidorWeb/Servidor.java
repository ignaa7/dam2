package servidorWeb;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class Servidor {
	public static void main(String[] args) throws IOException {
		ServerSocket servidor = new ServerSocket(80);
		System.out.println("Servidor iniciado...");
		
		while (true) {
			Socket socketCliente = servidor.accept();
			HiloServidor hilo = new HiloServidor(socketCliente);
			hilo.start();
		}
	}
}
