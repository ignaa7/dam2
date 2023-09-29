package modelo;

import java.time.LocalDate;

public class Persona implements Comparable<Persona> {
	private String dni;
	private Pais pais;
	private Zona zona;
	private String nombre;
	private Boolean minusvalia;
	private LocalDate fechaNacimiento;
	
	public Persona(String dni, Pais pais, Zona zona, String nombre, Boolean minusvalia, LocalDate fechaNacimiento) {
		super();
		this.dni = dni;
		this.pais = pais;
		this.zona = zona;
		this.nombre = nombre;
		this.minusvalia = minusvalia;
		this.fechaNacimiento = fechaNacimiento;
	}
	
	

	public String getDni() {
		return dni;
	}



	public void setDni(String dni) {
		this.dni = dni;
	}



	public Pais getPais() {
		return pais;
	}



	public void setPais(Pais pais) {
		this.pais = pais;
	}



	public Zona getZona() {
		return zona;
	}



	public void setZona(Zona zona) {
		this.zona = zona;
	}



	public String getNombre() {
		return nombre;
	}



	public void setNombre(String nombre) {
		this.nombre = nombre;
	}



	public Boolean getMinusvalia() {
		return minusvalia;
	}



	public void setMinusvalia(Boolean minusvalia) {
		this.minusvalia = minusvalia;
	}



	public LocalDate getFechaNacimiento() {
		return fechaNacimiento;
	}



	public void setFechaNacimiento(LocalDate fechaNacimiento) {
		this.fechaNacimiento = fechaNacimiento;
	}
	
	
	public Integer getEdad() {
		return LocalDate.now().getYear() - fechaNacimiento.getYear();
	}



	@Override
	public String toString() {
		return "dni=" + dni + ", pais=" + pais + ", zona=" + zona + ", nombre=" + nombre + ", minusvalia="
				+ minusvalia + ", fechaNacimiento=" + fechaNacimiento + ", ";
	}



	@Override
	public int compareTo(Persona persona) {
		int comparacionPorPais = this.pais.compareTo(persona.getPais());
        if (comparacionPorPais == 0) {
            return this.nombre.compareTo(persona.getNombre());
        }
        return comparacionPorPais;
	}
}
