/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.cliente;

import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.Socket;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import modelo.Jugador;

/**
 *
 * @author Ignacio
 */
public class HiloCliente extends Thread {
    
    private Socket socket;
    ArrayList<Jugador> jugadores;
    ObjectInputStream objectInputStream;
    
    public HiloCliente (Socket socket, ArrayList<Jugador> jugadores) throws IOException {
        this.socket = socket;
        this.jugadores = jugadores;
        
        
    }

    @Override
    public void run() {
        try {
            objectInputStream = new ObjectInputStream(socket.getInputStream());
        } catch (IOException ex) {
            Logger.getLogger(HiloCliente.class.getName()).log(Level.SEVERE, null, ex);
        }
        while (true) {
            try {
                jugadores = (ArrayList<Jugador>) objectInputStream.readObject();
                jugadores.forEach(System.out::println);
            } catch (IOException ex) {
                Logger.getLogger(HiloCliente.class.getName()).log(Level.SEVERE, null, ex);
            } catch (ClassNotFoundException ex) {
                Logger.getLogger(HiloCliente.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
    }
    
}
