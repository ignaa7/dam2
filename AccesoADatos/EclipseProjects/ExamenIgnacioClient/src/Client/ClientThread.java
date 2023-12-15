package Client;

import java.net.Socket;

public class ClientThread extends Thread {
	private Socket serverSocket;
	
	public ClientThread(Socket serverSocket) {
		this.serverSocket = serverSocket;
	}
	
	@Override
	public void run() {
		super.run();
		Reader reader = serverSocket.getInputStream();
		
		while(true) {
			System.out.println(reader.read());
		}
	}
}
