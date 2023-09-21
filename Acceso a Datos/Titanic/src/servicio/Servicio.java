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
	
	public Map<BoteSalvavidas, ArrayList<Persona>> realizarEvacuacion() {
		LinkedHashMap<BoteSalvavidas, ArrayList<Persona>> asignaciones;
		
		Zona zona = Zona.BABOR;
		
		BoteSalvavidas bote = null;
		
		while (!personas.isEmpty()) {
			switch (zona) {
			case BABOR:
				bote = botesBabor.remove(botesBabor.size() - 1);
				zona = Zona.ESTRIBOR;
				break;
			case ESTRIBOR:
				bote = botesBabor.remove(botesBabor.size() - 1);
				zona = Zona.POPA;
				break;
			case POPA:
				bote = botesBabor.remove(botesBabor.size() - 1);
				zona = Zona.PROA;
				break;
			case PROA:
				bote = botesBabor.remove(botesBabor.size() - 1);
				zona = Zona.BABOR;
				break;
			default: 
				break;
			}
			
			Boolean encontrado = false;
			Integer numPersonas = 0;
			
			for (int i = 0; i <= bote.getNumPlazas(); i++) {
				for (int j = 0; j < personas.size() && !encontrado; j++) {
					
				}
			}
		}
	}
}