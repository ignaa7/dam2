package modelo;

import java.time.LocalDate;

public class Pasajero extends Persona {
	private Integer numHabitacion;
	
	public Pasajero(String dni, Pais pais, Zona zona, String nombre, Boolean minusvalia, LocalDate fechaNacimiento, Integer numHabitacion) {
		super(dni, pais, zona, nombre, minusvalia, fechaNacimiento);
		this.numHabitacion = numHabitacion;
	}
}
