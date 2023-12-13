/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.pruebamocks.Servicio;

/**
 *
 * @author Ignacio
 */
public class Servicio implements IServicio {
    public String operacionPreferida;

    public Servicio(String operacionPreferida) {
        this.operacionPreferida = operacionPreferida;
    }
    
    @Override
    public int sumar(int num1, int num2) {
        return num1 + num2;
    }
    
    @Override
    public String getOperacionPreferida() {
        return operacionPreferida;
    }
}
