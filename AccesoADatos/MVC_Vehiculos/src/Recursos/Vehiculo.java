package Recursos;



public class Vehiculo {


private String marca;

private String modelo;

private String matricula;

private int idCliente;

public Vehiculo() {
	

}

public Vehiculo(String marca, String modelo, String matricula, int idCliente) {
	
	this.marca = marca;
	this.modelo = modelo;
	this.matricula = matricula;
	this.idCliente = idCliente;
}

public String getMarca() {
	return marca;
}

public void setMarca(String marca) {
	this.marca = marca;
}

public String getModelo() {
	return modelo;
}

public void setModelo(String modelo) {
	this.modelo = modelo;
}

public String getMatricula() {
	return matricula;
}

public void setMatricula(String matricula) {
	this.matricula = matricula;
}

public int getIdCliente() {
	return idCliente;
}

public void setIdCliente(int idCliente) {
	this.idCliente = idCliente;
}

@Override
public String toString() {
	return "Vehiculo [marca=" + marca + ", modelo=" + modelo + ", matricula=" + matricula + "]";
}






}