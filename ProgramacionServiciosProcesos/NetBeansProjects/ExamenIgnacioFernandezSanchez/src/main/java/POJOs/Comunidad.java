/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package POJOs;

/**
 *
 * @author dam
 */
public class Comunidad implements Comparable<Comunidad>{
    private int codigo;
    private String nombre;
    
    public Comunidad(int codigo, String nombre) {
        this.codigo = codigo;
        this.nombre = nombre;
    }

    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    @Override
    public String toString() {
        return "Comunidad{" + "codigo=" + codigo + ", nombre=" + nombre + '}';
    }

    @Override
    public int compareTo(Comunidad comunidad) {
        return this.getNombre().toLowerCase().compareTo(comunidad.getNombre().toLowerCase());
    }
    
    
}
