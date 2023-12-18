/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package POJOs;

import Excepciones.NotNullDNI;

/**
 *
 * @author ignac
 */
public class Persona {
    private String dni;
    private String nombre;
    private TipoPersona tipo;

    public Persona(String dni, String nombre, TipoPersona tipo) throws NotNullDNI {
        if (dni == null || dni.isEmpty()) {
            throw new NotNullDNI("El DNI no puede estar vacío");
        }
        this.dni = dni;
        this.nombre = nombre;
        this.tipo = tipo;
    }

    public String getDni() {
        return dni;
    }

    public String getNombre() {
        return nombre;
    }

    public TipoPersona getTipo() {
        return tipo;
    }

    @Override
    public String toString() {
        return "Persona{" + "dni=" + dni + ", nombre=" + nombre + ", tipo=" + tipo + '}';
    }
}
