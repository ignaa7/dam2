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
				System.out.println(cadena);
				
				if (file.exists()) {
					fsalida.write("HTTP/1.1 200 OK\r\n\r\n".getBytes());
					FileInputStream lecturaArchivo = new FileInputStream(file);
					byte[] buffer = new byte[1024];
					int bytesRead;
					
					while ((bytesRead = lecturaArchivo.read(buffer)) != -1) {
						fsalida.write(buffer, 0, bytesRead);
					}
					
					lecturaArchivo.close();
				}
				else {
					String errorMessage = "HTTP/1.1 404 Not Found\r\n\r\n No se ha encontrado el archivo.";
					fsalida.write(errorMessage.getBytes());
				}
				
				fsalida.close();
				fentrada.close();
				socketCliente.close();
			} catch (Exception e) {
				System.err.println(e.getMessage());
			}
		}
}
