/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package modelo;

import java.io.Serial;
import java.io.Serializable;
import java.util.UUID;
import java.util.concurrent.Flow;
import java.util.concurrent.SubmissionPublisher;

/**
 *
 * @author Ignacio
 */
public class Jugador implements Serializable{
    @Serial
    private static final long serialVersionUID = 1L;
    private String id;
    private int puntuacion;
    private int posicion;
    private final SubmissionPublisher<EventoCambioJugador> publisher = new SubmissionPublisher<>();
    
    public Jugador() {
        id = UUID.randomUUID().toString();
        puntuacion = 0;
        posicion = 0;
    }

    /**
     * @return the puntuacion
     */
    public int getPuntuacion() {
        return puntuacion;
    }

    /**
     * @param puntuacion the puntuacion to set
     */
    public void setPuntuacion(int puntuacion) {
        int puntuacionAnterior = this.puntuacion;
        this.puntuacion = puntuacion;
        
        if (puntuacionAnterior != puntuacion) {
            publisher.submit(new EventoCambioJugador(this));
        }
    }
    
    public void subscribe(Flow.Subscriber<? super EventoCambioJugador> subscriber) {
        publisher.subscribe(subscriber);
    }

    /**
     * @return the posicion
     */
    public int getPosicion() {
        return posicion;
    }

    /**
     * @param posicion the posicion to set
     */
    public void setPosicion(int posicion) {
        this.posicion = posicion;
    }
    
    @Override
    public String toString() {
        return "id: " + id + "\npuntuación: " + puntuacion + "\nposición: " + posicion;
    }
    
    
}
