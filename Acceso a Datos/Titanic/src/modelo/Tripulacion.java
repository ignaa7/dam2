package modelo;

import java.time.LocalDate;

public class Tripulacion extends Persona {
	private NivelResponsabilidad nivelResponsabilidad;
	
	public Tripulacion(String dni, Pais pais, Zona zona, String nombre, Boolean minusvalia, LocalDate fechaNacimiento, NivelResponsabilidad nivelResponsabilidad) {
		super(dni, pais, zona, nombre, minusvalia, fechaNacimiento);
		this.nivelResponsabilidad = nivelResponsabilidad;
	}
}
