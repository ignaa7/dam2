package controlador;

import java.util.ArrayList;
import java.util.LinkedHashMap;
import java.util.Map;

import modelo.BoteSalvavidas;
import modelo.Persona;
import servicio.Servicio;
import vista.Vista;

public class Controlador {
	public static void main(String[] args) {
		Servicio servicio = new Servicio();
		LinkedHashMap<BoteSalvavidas, ArrayList<Persona>> asignaciones = servicio.realizarEvacuacion();
		
		for (Map.Entry<BoteSalvavidas, ArrayList<Persona>> entry : asignaciones.entrySet()) {
			BoteSalvavidas bote = entry.getKey();
			ArrayList<Persona> personas = entry.getValue();
			
			Vista.mostrarMensaje("Bote:");
			Vista.mostrarMensaje(bote.toString());
			
			Vista.mostrarMensaje("Personas:");
			for (Persona persona : personas) {
				Vista.mostrarMensaje(persona.toString());
			}
			Vista.mostrarMensaje("");
		}
	}
}
