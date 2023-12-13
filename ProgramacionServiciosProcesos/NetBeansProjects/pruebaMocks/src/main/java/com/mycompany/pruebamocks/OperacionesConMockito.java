/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.pruebamocks;

import com.mycompany.pruebamocks.Servicio.Servicio;

/**
 *
 * @author dam
 */
public class OperacionesConMockito {
    private Servicio servicio;

    public OperacionesConMockito(Servicio servicio) {
        this.servicio = servicio;
    }
    
    public int sumar(int num1, int num2) {
        int res = servicio.sumar(num1, num2);
        System.out.println(res);
        return res;
    }
    
    public String getOperacionPreferida() {
        return servicio.getOperacionPreferida();
    }
}
