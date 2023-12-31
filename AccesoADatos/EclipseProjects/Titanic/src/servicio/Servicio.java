package servicio;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.TreeMap;

import modelo.BoteSalvavidas;
import modelo.DAOBotes;
import modelo.DAOPersonas;
import modelo.NivelResponsabilidad;
import modelo.Pasajero;
import modelo.Persona;
import modelo.Tripulacion;
import modelo.Zona;

public class Servicio {
	private TreeMap<Persona, Persona> personas = new TreeMap<Persona, Persona>();
	private ArrayList<BoteSalvavidas> botesProa = new ArrayList<BoteSalvavidas>();
	private ArrayList<BoteSalvavidas> botesPopa = new ArrayList<BoteSalvavidas>();
	private ArrayList<BoteSalvavidas> botesBabor = new ArrayList<BoteSalvavidas>();
	private ArrayList<BoteSalvavidas> botesEstribor = new ArrayList<BoteSalvavidas>();

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
	
	public LinkedHashMap<BoteSalvavidas, ArrayList<Persona>> realizarEvacuacion() {
		LinkedHashMap<BoteSalvavidas, ArrayList<Persona>> asignaciones = new LinkedHashMap<BoteSalvavidas, ArrayList<Persona>>();
		
		Zona zona = Zona.BABOR;
		Zona zonaActual = null;
		Boolean zonaVacia = false;
		
		while (!personas.isEmpty()) {
			BoteSalvavidas bote = null;
			
			switch (zona) {
			case BABOR:
				if (!botesBabor.isEmpty()) bote = botesBabor.remove(botesBabor.size() - 1);
				zonaActual = zona;
				zona = Zona.ESTRIBOR;
				break;
			case ESTRIBOR:
				if (!botesEstribor.isEmpty()) bote = botesEstribor.remove(botesEstribor.size() - 1);
				zonaActual = zona;
				zona = Zona.POPA;
				break;
			case POPA:
				if (!botesPopa.isEmpty()) bote = botesPopa.remove(botesPopa.size() - 1);
				zonaActual = zona;
				zona = Zona.PROA;
				break;
			case PROA:
				if (!botesProa.isEmpty()) bote = botesProa.remove(botesProa.size() - 1);
				zonaActual = zona;
				zona = Zona.BABOR;
				break;
			default: 
				break;
			}
			
			if (bote != null) {
				asignaciones.put(bote, new ArrayList<Persona>());
				
				Boolean encontrado;
				Integer numPersonas = 0;
				zonaVacia = false;
				
				while (numPersonas < bote.getNumPlazas() && !personas.isEmpty() && !zonaVacia) {
					Iterator<Map.Entry<Persona, Persona>> iterator = personas.entrySet().iterator();
					Persona personaElegida = null;
					encontrado = false;
					
			        while (iterator.hasNext() && !encontrado) {
			            Map.Entry<Persona, Persona> entry = iterator.next();
			            Persona persona = entry.getValue();
			            
			            if (persona.getEdad() < 18 && persona instanceof Pasajero && persona.getZona() == zonaActual) {
			            	personaElegida = persona;
			            	encontrado = true;
			            	numPersonas++;
			            }
			        }
			        
			        if (!encontrado) {
			        	iterator = personas.entrySet().iterator();
			        	
			        	while (iterator.hasNext() && !encontrado) {
				            Map.Entry<Persona, Persona> entry = iterator.next();
				            Persona persona = entry.getValue();
				            
				            if (persona.getEdad() > 65 && persona instanceof Pasajero && persona.getZona() == zonaActual) {
				            	personaElegida = persona;
				            	encontrado = true;
				            	numPersonas++;
				            }
				        }
			        }
			        
			        if (!encontrado) {
			        	iterator = personas.entrySet().iterator();
			        	
			        	while (iterator.hasNext() && !encontrado) {
				            Map.Entry<Persona, Persona> entry = iterator.next();
				            Persona persona = entry.getValue();
				            
				            if (persona.getMinusvalia() && persona instanceof Pasajero && persona.getZona() == zonaActual) {
				            	personaElegida = persona;
				            	encontrado = true;
				            	numPersonas++;
				            }
				        }
			        }
			        
			        if (!encontrado) {
			        	iterator = personas.entrySet().iterator();
			        	
			        	while (iterator.hasNext() && !encontrado) {
				            Map.Entry<Persona, Persona> entry = iterator.next();
				            Persona persona = entry.getValue();
				            
				            if (persona.getEdad() >= 18 && persona.getEdad() <= 65 && persona instanceof Pasajero && persona.getZona() == zonaActual) {
				            	personaElegida = persona;
				            	encontrado = true;
				            	numPersonas++;
				            }
				        }
			        }
			        
			        if (!encontrado) {
			        	iterator = personas.entrySet().iterator();
			        	
			        	while (iterator.hasNext() && !encontrado) {
				            Map.Entry<Persona, Persona> entry = iterator.next();
				            Persona persona = entry.getValue();
				            
				            if (persona instanceof Tripulacion && ((Tripulacion) persona).getNivelResponsabilidad() == NivelResponsabilidad.BAJA && persona.getZona() == zonaActual) {
				            	personaElegida = persona;
				            	encontrado = true;
				            	numPersonas++;
				            }
				        }
			        }
			        
			        if (!encontrado) {
			        	iterator = personas.entrySet().iterator();
			        	
			        	while (iterator.hasNext() && !encontrado) {
				            Map.Entry<Persona, Persona> entry = iterator.next();
				            Persona persona = entry.getValue();
				            
				            if (persona instanceof Tripulacion && ((Tripulacion) persona).getNivelResponsabilidad() == NivelResponsabilidad.MEDIA && persona.getZona() == zonaActual) {
				            	personaElegida = persona;
				            	encontrado = true;
				            	numPersonas++;
				            }
				        }
			        }
			        
			        if (!encontrado) {
			        	iterator = personas.entrySet().iterator();
			        	
			        	while (iterator.hasNext() && !encontrado) {
				            Map.Entry<Persona, Persona> entry = iterator.next();
				            Persona persona = entry.getValue();
				            
				            if (persona instanceof Tripulacion && ((Tripulacion) persona).getNivelResponsabilidad() == NivelResponsabilidad.ALTA && persona.getZona() == zonaActual) {
				            	personaElegida = persona;
				            	encontrado = true;
				            	numPersonas++;
				            }
				        }
			        }
			        
			        if (!encontrado) {
			        	iterator = personas.entrySet().iterator();
			        	
			        	while (iterator.hasNext() && !encontrado) {
				            Map.Entry<Persona, Persona> entry = iterator.next();
				            Persona persona = entry.getValue();
				            
				            if (persona instanceof Tripulacion && ((Tripulacion) persona).getNivelResponsabilidad() == NivelResponsabilidad.MUY_ALTA && persona.getZona() == zonaActual) {
				            	personaElegida = persona;
				            	encontrado = true;
				            	numPersonas++;
				            }
				        }
			        }
			        
			        if (encontrado) {
			        	ArrayList<Persona> personasBote = asignaciones.get(bote);
			        	personasBote.add(personaElegida);
			        	personas.remove(personaElegida);
			        }
			        else zonaVacia = true;
				}
			}
		}
		
		return asignaciones;
	}
}
