package modelo;

import java.time.LocalDate;

public class Pasajero extends Persona {
	private Integer numHabitacion;
	
	public Pasajero(String dni, Pais pais, Zona zona, String nombre, Boolean minusvalia, LocalDate fechaNacimiento, Integer numHabitacion) {
		super(dni, pais, zona, nombre, minusvalia, fechaNacimiento);
		this.numHabitacion = numHabitacion;
	}

	public Integer getNumHabitacion() {
		return numHabitacion;
	}

	public void setNumHabitacion(Integer numHabitacion) {
		this.numHabitacion = numHabitacion;
	}

	@Override
	public String toString() {
		return "Pasajero [" + super.toString() + "numHabitacion=" + numHabitacion + "]";
	}
}
