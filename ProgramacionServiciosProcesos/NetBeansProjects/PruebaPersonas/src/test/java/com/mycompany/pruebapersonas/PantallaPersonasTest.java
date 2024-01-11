/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/JUnit5TestClass.java to edit this template
 */
package com.mycompany.pruebapersonas;

import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;
import org.mockito.ArgumentMatchers;
import org.mockito.InjectMocks;
import org.mockito.Mock;
import org.mockito.Mockito;

/**
 *
 * @author ignac
 */
public class PantallaPersonasTest {
    @InjectMocks
    private static PantallaPersonas pantallaPersonas;
    
    @Mock
    private static DAOs.DAOTrabajador daoTrabajador;
    
    public PantallaPersonasTest() {
    }
    
    @BeforeAll
    public static void setUpClass() {
        daoTrabajador = Mockito.mock(DAOs.DAOTrabajador.class);
        
        pantallaPersonas = new PantallaPersonas(daoTrabajador);
    }
    
    @Test
    public void testComprobarCasados() {
        Mockito.when(daoTrabajador.comprobarCasados(ArgumentMatchers.anyInt())).thenReturn(true);
        System.out.println("Test comprobar casados:");
        boolean expResult = true;
        boolean result = pantallaPersonas.comprobarCasados(0);
        assertEquals(expResult, result);
    }
}
