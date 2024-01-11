/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package POJOs;

/**
 *
 * @author ignac
 */
public class Empresa implements Comparable<Empresa> {
    private int codigo;
    private String nombre;

    public Empresa(int codigo, String nombre) {
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
        return "Empresa{" + "codigo=" + codigo + ", nombre=" + nombre + '}';
    }

    @Override
    public int compareTo(Empresa empresa) {
        return this.getNombre().compareToIgnoreCase(empresa.getNombre());
    }
}
