/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package POJOs;

/**
 *
 * @author ignac
 */
public class Trabajador {
    private int codigoEmpresa;
    private String nombre;
    private double sueldo;
    private boolean casado;

    public Trabajador(int codigoEmpresa, String nombre, double sueldo, boolean casado) {
        this.codigoEmpresa = codigoEmpresa;
        this.nombre = nombre;
        this.sueldo = sueldo;
        this.casado = casado;
    }

    public int getCodigoEmpresa() {
        return codigoEmpresa;
    }

    public void setCodigoEmpresa(int codigoEmpresa) {
        this.codigoEmpresa = codigoEmpresa;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public double getSueldo() {
        return sueldo;
    }

    public void setSueldo(double sueldo) {
        this.sueldo = sueldo;
    }

    public boolean isCasado() {
        return casado;
    }

    public void setCasado(boolean casado) {
        this.casado = casado;
    }
}
