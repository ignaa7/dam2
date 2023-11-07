/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.servidor;

import modelo.Jugador;
import java.io.DataInputStream;
import java.io.IOException;
import java.net.Socket;

/**
 *
 * @author Ignacio
 */
public class HiloServidor extends Thread {
	private final DataInputStream dataInputStream;
        private final Jugador jugador;
	
	public HiloServidor (Socket socketCliente, Jugador jugador) throws IOException {
                this.jugador = jugador;
                
                dataInputStream = new DataInputStream(socketCliente.getInputStream());
                
	}
	
        @Override
	public void run () {
            try {
                try (dataInputStream) {
                    while (jugador.getPuntuacion() < 5) {
                        int movimiento = dataInputStream.readInt();
                        
                        jugador.mover(movimiento);
                    }
                }
            } catch (IOException e) {
		System.err.println(e.getMessage());
            }
	}
}
