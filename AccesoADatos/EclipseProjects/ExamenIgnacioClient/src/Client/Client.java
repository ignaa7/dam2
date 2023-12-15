package Client;

import java.io.IOException;
import java.net.Socket;
import java.net.UnknownHostException;

public class Client {
	public static void main(String[] args) throws UnknownHostException, IOException {
		String ip = "localhost";
		int port = 4000;
		
		Socket socket = new Socket(ip, port);
		Writer writer = socket.getOutputStream();
		Reader reader = socket.getInputStream();
		
		new ClientThread(socket);
		
		System.out.println(reader.read());
		
		while (true) {
			String message = //leer de teclado;
			writer.write(message);
		}
	}
}
