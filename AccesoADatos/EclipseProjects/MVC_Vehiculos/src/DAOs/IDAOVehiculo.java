package DAOs;


import java.util.List;

import Recursos.Vehiculo;



	public interface IDAOVehiculo 
	{ public int insertarVehiculo(Vehiculo vehiculo, String nombreUsuario);
	  public int eliminarVehiculo(Vehiculo vehiculo);
	  public int eliminarVehiculo(String matricula);
	  public int eliminarVehiculos(List<Vehiculo> lstVehiculos);
	  public Vehiculo getVehiculo(String matricula);
	  public  List<Vehiculo> getVehiculos();
	public int modificarVehiculo(String marca, String modelo, String matricula);
 


  
	
	

}
