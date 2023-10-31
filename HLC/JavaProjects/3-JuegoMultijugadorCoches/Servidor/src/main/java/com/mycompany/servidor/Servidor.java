/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.servidor;

import java.io.IOException;
import java.io.ObjectOutputStream;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.ArrayList;
import modelo.Jugador;

/**
 *
 * @author Ignacio
 */
public class Servidor {
    
    private static ArrayList jugadores = new ArrayList();

    public static void main(String[] args) throws IOException {
        ServerSocket servidor = new ServerSocket(2000);
		System.out.println("Servidor iniciado...");
		
		while (true) {
			Socket socketCliente = servidor.accept();
                        Jugador jugador = new Jugador();
			HiloServidor hilo = new HiloServidor(socketCliente, jugador);
			hilo.start();
                        ObjectOutputStream objectOutputStream = new ObjectOutputStream(socketCliente.getOutputStream());
                        jugadores.add(new Jugador());
                        objectOutputStream.writeObject(jugadores);
		}
    }
}
