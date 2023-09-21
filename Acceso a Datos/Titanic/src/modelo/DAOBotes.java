package modelo;

import java.util.ArrayList;
import java.util.Arrays;

public class DAOBotes {
	public static ArrayList<BoteSalvavidas> getBotes() {
		return new ArrayList<>(Arrays.asList(new BoteSalvavidas(2, Zona.BABOR),
				new BoteSalvavidas(2, Zona.POPA),
				new BoteSalvavidas(1, Zona.PROA),
				new BoteSalvavidas(4, Zona.ESTRIBOR),
				new BoteSalvavidas(3, Zona.PROA),
				new BoteSalvavidas(2, Zona.POPA),
				new BoteSalvavidas(1, Zona.BABOR)));
	}
}
