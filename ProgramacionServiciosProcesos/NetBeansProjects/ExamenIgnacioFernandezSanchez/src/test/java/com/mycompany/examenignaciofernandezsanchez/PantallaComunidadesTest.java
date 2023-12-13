/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/JUnit5TestClass.java to edit this template
 */
package com.mycompany.examenignaciofernandezsanchez;

import DAOs.DAOVivienda;
import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.BeforeEach;
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
public class PantallaComunidadesTest {
    
    @InjectMocks
    private static PantallaComunidades pantallaComunidades;
    
    @Mock
    private static DAOVivienda daoVivienda;
    
    public PantallaComunidadesTest() {
        daoVivienda = Mockito.mock(DAOVivienda.class);
        
        pantallaComunidades = new PantallaComunidades(daoVivienda);
    }

    /**
     * Test of main method, of class PantallaComunidades.
     */
    @Test
    public void testComprobarMorososTrue() {
        Mockito.when(daoVivienda.comprobarMorosos()).thenReturn(true);
        System.out.println("Test comprobar morosos con morosos:");
        boolean expResult = true;
        boolean result = daoVivienda.comprobarMorosos();
        assertEquals(expResult, result);
    }
    
    @Test
    public void testComprobarMorososFalse() {
        Mockito.when(daoVivienda.comprobarMorosos()).thenReturn(false);
        System.out.println("Test comprobar morosos sin morosos:");
        boolean expResult = false;
        boolean result = daoVivienda.comprobarMorosos();
        assertEquals(expResult, result);
    }
    
}
