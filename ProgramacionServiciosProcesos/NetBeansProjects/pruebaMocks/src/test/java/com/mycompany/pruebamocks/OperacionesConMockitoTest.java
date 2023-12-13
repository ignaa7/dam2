/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/JUnit5TestClass.java to edit this template
 */
package com.mycompany.pruebamocks;

import com.mycompany.pruebamocks.Servicio.Servicio;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;
import org.mockito.InjectMocks;
import org.mockito.Mock;
import org.mockito.Mockito;

/**
 *
 * @author dam
 */
public class OperacionesConMockitoTest {
    
    @InjectMocks
    private static OperacionesConMockito operaciones;
    
    @Mock
    private static Servicio servicio;
    
    public OperacionesConMockitoTest() {
    }
    
    @BeforeAll
    public static void setUpClass() {
        servicio = Mockito.mock(Servicio.class);
        servicio.operacionPreferida = "suma";
        
        operaciones = new OperacionesConMockito(servicio);
    }

    /**
     * Test of sumar method, of class Operaciones.
     */
    @Test
    public void testSumar() {
        Mockito.when(servicio.sumar(3, 2)).thenReturn(5);
        System.out.println("sumar");
        int num1 = 3;
        int num2 = 2;
        int expResult = 5;
        int result = operaciones.sumar(num1, num2);
        assertEquals(expResult, result);
    }

    /**
     * Test of getOperacionPreferida method, of class Operaciones.
     */
    @Test
    public void testGetOperacionPreferida() {
        Mockito.when(servicio.getOperacionPreferida()).thenReturn("suma");
        System.out.println("getOperacionPreferida");
        
        String expResult = "suma";
        String result = operaciones.getOperacionPreferida();
        assertEquals(expResult, result);
    }
    
}