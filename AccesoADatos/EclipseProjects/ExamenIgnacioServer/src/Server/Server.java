package Server;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.ArrayList;
import java.util.List;

public class Server {
	public static void main(String[] args) throws IOException {
		int port = 4000;
		List<Socket> clientSockets = new ArrayList<Socket>();
		
		ServerSocket serverSocket = new ServerSocket(port);
		
		while (clientSockets.size() < 2) {
			Socket clientSocket = serverSocket.accept();
			clientSockets.add(clientSocket);
			
			new ServerThread(clientSockets, clientSocket).start();
		}
	}
}
