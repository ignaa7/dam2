package servidorWeb;

import java.net.Socket;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.OutputStream;
import java.io.InputStreamReader;
import java.io.File;
import java.io.FileInputStream;

public class HiloServidor extends Thread {
	Socket socketCliente = null;
	BufferedReader fentrada;
	OutputStream fsalida;
	
	public HiloServidor (Socket socketCliente) throws IOException {
		this.socketCliente = socketCliente;
		fsalida = socketCliente.getOutputStream();
	}
	
	public void run () {
			try {				
				BufferedReader fentrada = new BufferedReader(new InputStreamReader(socketCliente.getInputStream()));
				
				String cadena = fentrada.readLine();
				String nombreArchivo = cadena.split(" ")[1];
				File file = new File("src/html" + nombreArchivo);
				
				FileInputStream lecturaArchivo = new FileInputStream(file);
				byte[] buffer = new byte[1024];
				int bytesRead;
				
				while ((bytesRead = lecturaArchivo.read(buffer)) != -1) {
					fsalida.write(buffer, 0, bytesRead);
				}
				
				fsalida.close();
				fentrada.close();
				lecturaArchivo.close();
				socketCliente.close();
			} catch (Exception e) {
				System.err.println(e.getMessage());
			}
		}
}
