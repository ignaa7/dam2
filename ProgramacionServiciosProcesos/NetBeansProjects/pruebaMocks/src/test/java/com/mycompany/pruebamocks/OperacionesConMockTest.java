/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/JUnit5TestClass.java to edit this template
 */
package com.mycompany.pruebamocks;

import com.mycompany.pruebamocks.Servicio.IServicio;
import com.mycompany.pruebamocks.Servicio.ServicioMock;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;
import org.mockito.InjectMocks;
import org.mockito.Mock;

/**
 *
 * @author Ignacio
 */
public class OperacionesConMockTest {
    
    private static OperacionesConMock operaciones;
    
    private static IServicio servicio;
    
    public OperacionesConMockTest() {
    }
    
    @BeforeAll
    public static void setUpClass() {
        servicio = new ServicioMock();
        
        operaciones = new OperacionesConMock(servicio);
    }

    /**
     * Test of sumar method, of class OperacionesConMock.
     */
    @Test
    public void testSumar() {
        System.out.println("sumar");
        int num1 = 2;
        int num2 = 3;
        int expResult = 5;
        int result = operaciones.sumar(num1, num2);
        assertEquals(expResult, result);
    }

    /**
     * Test of getOperacionPreferida method, of class OperacionesConMock.
     */
    @Test
    public void testGetOperacionPreferida() {
        System.out.println("getOperacionPreferida");
        String expResult = "suma";
        String result = operaciones.getOperacionPreferida();
        assertEquals(expResult, result);
    }
    
}
