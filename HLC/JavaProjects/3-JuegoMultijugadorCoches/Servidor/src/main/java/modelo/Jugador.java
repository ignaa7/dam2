/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package modelo;

import java.io.Serial;
import java.io.Serializable;
import java.util.UUID;

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
        this.puntuacion = puntuacion;
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
    
    
}
