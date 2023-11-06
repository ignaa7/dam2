/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.piscina;

/**
 *
 * @author dam
 */
public class Piscina {

    private int nivel;
    public final int MAX_NIVEL;
    
    public Piscina (int max) {
        if (max < 0) max = 0;
        
        MAX_NIVEL = max;
    }
    
    public int getNivel() {
        return nivel;
    }
    
    public void vaciar (int cantidad) throws Exception {
        nivel -= cantidad;
        
        if (nivel < 0) {
            throw new Exception("Nivel por debajo de 0");
        }
    }
    
    public void llenar (int cantidad) throws Exception {
        nivel += cantidad;
        
        if (nivel > MAX_NIVEL) {
            throw new Exception("Nivel por encima del nivel máximo");
        }
    }
}
