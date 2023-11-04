/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package modelo;

import java.util.UUID;
import java.util.concurrent.Flow;
import java.util.concurrent.SubmissionPublisher;

/**
 *
 * @author Ignacio
 */
public class Jugador{
    private String id;
    private int puntuacion;
    private int posicion;
    private final SubmissionPublisher<EventoCambioJugador> publisher = new SubmissionPublisher<>();
    
    public Jugador() {
        id = UUID.randomUUID().toString();
        puntuacion = 0;
        posicion = 0;
    }

    public int getPuntuacion() {
        return puntuacion;
    }
    
    public void sumarPunto() {
        puntuacion += 1;
        publisher.submit(new EventoCambioJugador(this));
    }

    public int getPosicion() {
        return posicion;
    }
    
    public void mover(String movimiento) {
        if (movimiento.equals("derecha")) {
            posicion += 1;
            publisher.submit(new EventoCambioJugador(this));
        }
        else if (movimiento.equals("izquierda")) {
            posicion -= 1;
            publisher.submit(new EventoCambioJugador(this));
        }
    }
    
    public void subscribe(Flow.Subscriber<? super EventoCambioJugador> subscriber) {
        publisher.subscribe(subscriber);
    }
    
    @Override
    public String toString() {
        return "id: " + id + "\npuntuación: " + puntuacion + "\nposición: " + posicion;
    }
    
    
}
