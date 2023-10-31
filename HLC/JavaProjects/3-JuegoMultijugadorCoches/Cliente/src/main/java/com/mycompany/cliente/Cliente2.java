/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.cliente;

import java.io.BufferedReader;
import java.io.DataInputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.ObjectInputStream;
import java.io.PrintWriter;
import java.net.Socket;
import java.util.ArrayList;
import modelo.Jugador;

/**
 *
 * @author Ignacio
 */
public class Cliente2 {

    public static void main(String[] args) throws IOException, ClassNotFoundException {
		String host = "localhost";
		int puerto = 2000;
		Socket socket = new Socket(host, puerto);
		PrintWriter fsalida = new PrintWriter(socket.getOutputStream(), true);
		ObjectInputStream objectInputStream = new ObjectInputStream(socket.getInputStream());
                DataInputStream dataInputStream = new DataInputStream(socket.getInputStream());
                
		BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
                
                ArrayList<Jugador> jugadores = (ArrayList<Jugador>) objectInputStream.readObject();

		String cadena = "";
                boolean fin = false;
                
		do {
                    fin = dataInputStream.readBoolean();
                    System.out.print("Introduce cadena: ");
                    cadena = in.readLine();

                    fsalida.println(cadena);
		} while (!fin);
                
		fsalida.close();
		objectInputStream.close();
                dataInputStream.close();
		System.out.println("Fin del envío... ");
		in.close();
		socket.close();
	}
}
