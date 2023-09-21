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

	public Integer getId() {
		return id;
	}

	public void setId(Integer id) {
		this.id = id;
	}

	public Integer getNumPlazas() {
		return numPlazas;
	}

	public void setNumPlazas(Integer numPlazas) {
		this.numPlazas = numPlazas;
	}

	public Zona getZona() {
		return zona;
	}

	public void setZona(Zona zona) {
		this.zona = zona;
	}

	public static Integer getGeneradorId() {
		return generadorId;
	}

	public static void setGeneradorId(Integer generadorId) {
		BoteSalvavidas.generadorId = generadorId;
	}
	
}
