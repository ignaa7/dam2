/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package modelo;

import com.fasterxml.jackson.annotation.JsonProperty;
import java.util.concurrent.Flow;
import java.util.concurrent.SubmissionPublisher;

/**
 *
 * @author Ignacio
 */
public class Jugador{
    @JsonProperty
    private int id;
    private int puntuacion;
    private int posicion;
    private int ultimoExtremoTocado = -1;
    private final int extremoIzquierdo = -225;
    private final int extremoDerecho = 250;
    private final SubmissionPublisher<EventoCambioJugador> publisher = new SubmissionPublisher<>();
    
    public Jugador(int id) {
        this.id = id;
        puntuacion = 0;
        posicion = 0;
    }
    
    public Jugador() {
        
    }
    
    public int getId() {
        return id;
    }

    public int getPuntuacion() {
        return puntuacion;
    }
    
    public void sumarPunto() {
        puntuacion += 1;
    }

    public int getPosicion() {
        return posicion;
    }
    
    public void mover(int movimiento) {
        if (movimiento == 0 && posicion < extremoDerecho) {
            posicion += 3;
            
            if (posicion >= extremoDerecho && ultimoExtremoTocado != 0) {
                sumarPunto();
                ultimoExtremoTocado = 0;
            }
            
            publisher.submit(new EventoCambioJugador(this));
        }
        else if (movimiento == 1 && posicion > extremoIzquierdo) {
            posicion -= 3;
            
            if (posicion <= extremoIzquierdo && ultimoExtremoTocado != 1) {
                sumarPunto();
                ultimoExtremoTocado = 1;
            }
            
            publisher.submit(new EventoCambioJugador(this));
        }
    }
    
    public void subscribe(Flow.Subscriber<? super EventoCambioJugador> subscriber) {
        publisher.subscribe(subscriber);
        publisher.submit(new EventoCambioJugador(this));
    }
    
    @Override
    public String toString() {
        return "id: " + id + "\npuntuación: " + puntuacion + "\nposición: " + posicion;
    }
    
    
}
