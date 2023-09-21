package servicio;

import java.util.ArrayList;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.TreeMap;

import modelo.BoteSalvavidas;
import modelo.DAOBotes;
import modelo.DAOPersonas;
import modelo.Persona;
import modelo.Zona;

public class Servicio {
	private TreeMap<Persona, Persona> personas = new TreeMap<Persona, Persona>();
	private ArrayList<BoteSalvavidas> botesProa;
	private ArrayList<BoteSalvavidas> botesPopa;
	private ArrayList<BoteSalvavidas> botesBabor;
	private ArrayList<BoteSalvavidas> botesEstribor;

	public Servicio() {
		pedirPersonas();
		pedirBotes();
	}
	
	public void pedirPersonas() {
		ArrayList<Persona> arrayPersonas = DAOPersonas.getPersonas();
		
		for (Persona persona : arrayPersonas) {
			personas.put(persona, persona);
		}
	}
	
	public void pedirBotes() {
		ArrayList<BoteSalvavidas> botes = DAOBotes.getBotes();
		
		for (BoteSalvavidas bote : botes) {
			if (bote.getZona() == Zona.PROA) botesProa.add(bote);
			if (bote.getZona() == Zona.POPA) botesPopa.add(bote);
			if (bote.getZona() == Zona.BABOR) botesBabor.add(bote);
			if (bote.getZona() == Zona.ESTRIBOR) botesEstribor.add(bote);
		}
	}
	
	public Map<BoteSalvavidas, Persona> realizarEvacuacion() {
		LinkedHashMap<BoteSalvavidas, Persona> asignaciones;
	}
}
