package modelo;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.Arrays;

public class DAOPersonas {
	public static ArrayList<Persona> getPersonas() {
		return new ArrayList<>(Arrays.asList(new Tripulacion("47263723T", Pais.ALEMANIA, Zona.BABOR, "Laura", false, LocalDate.of(2002, 2, 11), NivelResponsabilidad.MUY_ALTA),
				new Pasajero("47263723T", Pais.ESPAÑA, Zona.PROA, "Penélope", false, LocalDate.of(2022, 12, 14), 12),
				new Pasajero("47263723T", Pais.FRANCIA, Zona.ESTRIBOR, "María", false, LocalDate.of(2013, 4, 15), 3),
				new Pasajero("47263723T", Pais.RUSIA, Zona.POPA, "Tomás", true, LocalDate.of(2000, 12, 1), 144),
				new Tripulacion("47263723T", Pais.INGLATERRA, Zona.POPA, "Gabriel", true, LocalDate.of(1956, 11, 1), NivelResponsabilidad.BAJA),
				new Tripulacion("47263723T", Pais.FRANCIA, Zona.POPA, "Federica", false, LocalDate.of(1999, 9, 9), NivelResponsabilidad.ALTA),
				new Pasajero("47263723T", Pais.ALEMANIA, Zona.ESTRIBOR, "Iván", true, LocalDate.of(1987, 2, 2), 41),
				new Pasajero("47263723T", Pais.ESPAÑA, Zona.BABOR, "Violeta", false, LocalDate.of(1969, 9, 28), 222),
				new Tripulacion("47263723T", Pais.FRANCIA, Zona.PROA, "Javier", false, LocalDate.of(2015, 6, 13), NivelResponsabilidad.MEDIA),
				new Pasajero("47263723T", Pais.INGLATERRA, Zona.BABOR, "Godofredo", true, LocalDate.of(2001, 25, 4), 90)));
	}
}
