package Servicio;

import java.util.ArrayList;
import java.util.TreeMap;

import modelo.DAOPersonas;
import modelo.Persona;

public class Servicio {
	private TreeMap<Persona, Persona> personas = new TreeMap<Persona, Persona>();

	public Servicio() {
		ArrayList<Persona> arrayPersonas = DAOPersonas.getPersonas();
		
		for (Persona persona : arrayPersonas) {
			personas.put(persona, persona);
		}
	}
}
