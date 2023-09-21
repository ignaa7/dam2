package modelo;

public class BoteSalvavidas {
	private Integer id;
	private Integer numPlazas;
	private Zona zona;
	private static Integer generadorId = 1;
	
	public BoteSalvavidas(Integer numPlazas, Zona zona) {
		this.numPlazas = numPlazas;
		this.zona = zona;
		this.id = generadorId;
		generadorId++;
	}
}
