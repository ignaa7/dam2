/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package POJOs;

/**
 *
 * @author ignac
 */
public class Piso {
    private int numeroRegistro;
    private String direccion;

    public Piso(int numeroRegistro, String direccion) {
        this.numeroRegistro = numeroRegistro;
        this.direccion = direccion;
    }

    public int getNumeroRegistro() {
        return numeroRegistro;
    }

    public String getDireccion() {
        return direccion;
    }

    @Override
    public String toString() {
        return "Piso{" + "numeroRegistro=" + numeroRegistro + ", direccion=" + direccion + '}';
    }
}
