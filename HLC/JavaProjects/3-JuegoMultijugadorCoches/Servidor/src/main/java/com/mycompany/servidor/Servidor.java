/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.servidor;

import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.ArrayList;
import modelo.Jugador;

/**
 *
 * @author Ignacio
 */
public class Servidor {
    public static void main(String[] args) throws IOException {
        ServerSocket servidor = new ServerSocket(2000);
        ArrayList<Jugador> jugadores = new ArrayList();
        ArrayList<Socket> clientes = new ArrayList();
        
        int idCont = 1;
		
	while (jugadores.size() < 4) {
		Socket socketCliente = servidor.accept();
                
                Jugador jugador = new Jugador(idCont);
                DataOutputStream playerDataOutputStream = new DataOutputStream(socketCliente.getOutputStream());
                playerDataOutputStream.writeUTF("Jugador " + idCont);
                idCont++;
                
                HiloObservable hiloObservable = new HiloObservable(jugadores, clientes);
                hiloObservable.start();
                jugador.subscribe(hiloObservable);
                
                clientes.add(socketCliente);
                jugadores.add(jugador);
                
		HiloServidor hilo = new HiloServidor(socketCliente, jugador);
		hilo.start();
	}
    }
}
