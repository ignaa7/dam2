/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.servidor;

import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;
import java.util.ArrayList;
import java.util.concurrent.Flow;
import modelo.EventoCambioJugador;
import modelo.Jugador;
import java.util.concurrent.Flow.Subscriber;
import java.util.logging.Level;
import java.util.logging.Logger;
import com.fasterxml.jackson.databind.ObjectMapper;


/**
 *
 * @author Ignacio
 */
public class HiloObservable extends Thread implements Subscriber<EventoCambioJugador> {
    private ArrayList<Jugador> jugadores;
    private ArrayList<Socket> clientes;
    private Flow.Subscription subscription;
    
    public HiloObservable(ArrayList<Jugador> jugadores, ArrayList<Socket> clientes) {
        this.jugadores = jugadores;
        this.clientes = clientes;
    }
    
    @Override
    public void onSubscribe(Flow.Subscription subscription) {
        this.subscription = subscription;
        subscription.request(1);
    }

    @Override
    public void onNext(EventoCambioJugador item) {
        // Se llama cuando se produce un cambio en cualquier jugador
        // Envía el array actualizado a todos los clientes
        clientes.forEach((socketCliente) -> {
            try {
                if (!socketCliente.isClosed()) {
                    ObjectMapper objectMapper = new ObjectMapper();
                    String json = objectMapper.writeValueAsString(jugadores);

                    DataOutputStream dataOutputStream = new DataOutputStream(socketCliente.getOutputStream());
                    dataOutputStream.writeUTF(json);
                }
            } catch (IOException ex) {
                Logger.getLogger(HiloObservable.class.getName()).log(Level.SEVERE, null, ex);
            }
        });
        
        subscription.request(1);
    }

    @Override
    public void onError(Throwable throwable) {
        // Manejar errores
    }

    @Override
    public void onComplete() {
        // Manejar la finalización del flujo de eventos
    }

    @Override
    public void run() {
        
    }
    
}
