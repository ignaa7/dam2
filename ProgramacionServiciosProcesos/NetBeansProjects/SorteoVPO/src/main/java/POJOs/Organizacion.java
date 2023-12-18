/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package POJOs;

/**
 *
 * @author ignac
 */
public class Organizacion {
    private String nombre;
    private String nif;

    public Organizacion(String nombre, String nif) {
        this.nombre = nombre;
        this.nif = nif;
    }

    public String getNombre() {
        return nombre;
    }

    public String getNif() {
        return nif;
    }

    @Override
    public String toString() {
        return "Organizacion{" + "nombre=" + nombre + ", nif=" + nif + '}';
    }
}
