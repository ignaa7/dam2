/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package POJOs;

/**
 *
 * @author ignac
 */
public class Ganador<T,E> {
    private T vivienda;
    private E propietario;

    public Ganador(T vivienda, E propietario) {
        if ((vivienda instanceof Casa || vivienda instanceof Piso) && (propietario instanceof Persona || propietario instanceof Organizacion)) {
            this.vivienda = vivienda;
            this.propietario = propietario;
        }
    }

    public T getVivienda() {
        return vivienda;
    }

    public E getPropietario() {
        return propietario;
    }
}
