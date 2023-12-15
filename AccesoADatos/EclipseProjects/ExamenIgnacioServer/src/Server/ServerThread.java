package Server;

import java.io.Reader;
import java.io.Writer;
import java.net.Socket;
import java.util.ArrayList;
import java.util.List;

public class ServerThread extends Thread {
	private List<Socket> clientSockets = new ArrayList<Socket>();
	private Socket clientSocket;
	
	public ServerThread(List<Socket> clientSockets, Socket clientSocket) {
		this.clientSockets = clientSockets;
		this.clientSocket = clientSocket;
	}
	
	@Override
	public void run() {
		super.run();
		Writer writer = clientSocket.getOutputStream();
		Reader reader = clientSocket.getInputStream();
		
		String message;
		
		do {
			message = reader.read();
			
			for (Socket socket : clientSockets) {
				if (socket != clientSocket) {
					Writer writer = socket.getOutputStream();
					writer.write(message);
					writer.close();
				}
			}
		} while (!message.equals("*"));
		
		writer.close();
		reader.close();
	}
}
