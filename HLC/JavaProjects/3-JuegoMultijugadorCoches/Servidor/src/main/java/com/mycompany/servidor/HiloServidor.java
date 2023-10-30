/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.servidor;

import modelo.Jugador;
import java.io.BufferedReader;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.PrintWriter;
import java.net.Socket;

/**
 *
 * @author Ignacio
 */
public class HiloServidor extends Thread {
        Socket socketCliente = null;
	BufferedReader fentrada;
	DataOutputStream dataOutputStream;
        Jugador jugador;
	
	public HiloServidor (Socket socketCliente, Jugador jugador) throws IOException {
		this.socketCliente = socketCliente;
                this.jugador = jugador;
                
		dataOutputStream = new DataOutputStream(socketCliente.getOutputStream());
                fentrada = new BufferedReader(new InputStreamReader(socketCliente.getInputStream()));
	}
	
	public void run () {
            try {
                while (jugador.getPuntuacion() < 5) {
                    System.out.println(fentrada.readLine());
                    jugador.setPuntuacion(jugador.getPuntuacion() + 1);
                }
                
                dataOutputStream.writeBoolean(true);
                
		dataOutputStream.close();
		fentrada.close();
		socketCliente.close();
            } catch (Exception e) {
		System.err.println(e.getMessage());
            }
	}
}
