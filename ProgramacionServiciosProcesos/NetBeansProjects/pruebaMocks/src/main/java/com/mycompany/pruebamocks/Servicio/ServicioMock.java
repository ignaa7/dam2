/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.pruebamocks.Servicio;

/**
 *
 * @author Ignacio
 */
public class ServicioMock implements IServicio{

    @Override
    public int sumar(int num1, int num2) {
        return 5;
    }

    @Override
    public String getOperacionPreferida() {
        return "suma";
    }
    
}
