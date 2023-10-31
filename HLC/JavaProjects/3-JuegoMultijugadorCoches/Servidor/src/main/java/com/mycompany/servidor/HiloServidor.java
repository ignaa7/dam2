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
import java.util.ArrayList;

/**
 *
 * @author Ignacio
 */
public class HiloServidor extends Thread {
        private Socket socketCliente = null;
	private BufferedReader fentrada;
	private DataOutputStream dataOutputStream;
        private ArrayList jugadores;
        private Jugador jugador;
	
	public HiloServidor (Socket socketCliente, ArrayList<Jugador> jugadores) throws IOException {
		this.socketCliente = socketCliente;
                this.jugadores = jugadores;
                this.jugador = new Jugador();
                
                fentrada = new BufferedReader(new InputStreamReader(socketCliente.getInputStream()));
	}
	
	public void run () {
            try {
                while (jugador.getPuntuacion() < 1) {
                    System.out.println(fentrada.readLine());
                    jugador.setPuntuacion(jugador.getPuntuacion() + 1);
                }
                
		fentrada.close();
		socketCliente.close();
            } catch (Exception e) {
		System.err.println(e.getMessage());
            }
	}
}
