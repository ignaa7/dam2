package Controller;




import java.util.List;

import javax.swing.JComboBox;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;

import DAOs.DAOCliente;
import DAOs.DAOVehiculoImpl;
import Recursos.Cliente;
import Recursos.Vehiculo;
import Vista.PanelCRUD;





public class ControllerCRUD
{
	
	
	public static void cargarTabla( JTable tablaVehiculos)
	{ //DefaultTableModel modeloDeDatosTabla = (DefaultTableModel) tablaVehiculos.getModel();
		List<Vehiculo> lstVehiculos = DAOVehiculoImpl.getInstance().getVehiculos();
		
		DefaultTableModel modelo=new DefaultTableModel();
	 
	 
	 modelo.addColumn("Marca");

	 modelo.addColumn("Modelo");

	 modelo.addColumn("Matricula");

	
    
   
	 Object[] registroLeido = new Object [3];
	 
	 for(Vehiculo vehiculo:lstVehiculos)

	 {	 

			registroLeido[0]= vehiculo.getMarca();

			registroLeido[1]= vehiculo.getModelo();

			registroLeido[2]=  vehiculo.getMatricula();
	 



		 modelo.addRow(registroLeido);

	 }
	 
	 tablaVehiculos.setModel(modelo);
	}
	
	
	public static void cargarClientes(JComboBox<String> cbClientes) {
		List<Cliente> clientes = DAOCliente.getInstance().getClientes();
		
		for (Cliente cliente : clientes) {
			cbClientes.addItem(cliente.getNombreUsuario());
		}
	}
	
	
	public static boolean insertarVehiculo( PanelCRUD frmVehiculo, JTable tablaVehiculos, int idCliente)
	{ boolean insertado=false;
	Vehiculo vehiculo=new Vehiculo();
	 
	 
	 
	 vehiculo.setMarca(frmVehiculo.getTxtMarca().getText());

	 vehiculo.setModelo(frmVehiculo.getTxtModelo().getText());

	 vehiculo.setMatricula(frmVehiculo.getTxtMatricula().getText());
	 
	 vehiculo.setIdCliente(idCliente);
	 
		if (DAOVehiculoImpl.getInstance().insertarVehiculo(vehiculo)!=0)
		{insertado=true;
		cargarTabla( tablaVehiculos);
		}
     return insertado;		
	}


	public static boolean insertarCliente(String nombreUsuario, JComboBox<String> cbClientes) {
		boolean insertado = false;
		
		if (DAOCliente.getInstance().insertarCliente(nombreUsuario) != 0) {
			insertado = true;
			cargarClientes(cbClientes);
		}
		
		return insertado;
	}
	
	
	

}
