package Controller;




import java.util.List;

import javax.swing.DefaultComboBoxModel;
import javax.swing.JComboBox;
import javax.swing.JTable;
import javax.swing.event.TableModelEvent;
import javax.swing.event.TableModelListener;
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
		
		modelo.addTableModelListener(new TableModelListener() {
            @Override
            public void tableChanged(TableModelEvent e) {
                if (tablaVehiculos.getRowCount() > 0 && e.getType() == TableModelEvent.UPDATE && e.getFirstRow() != TableModelEvent.HEADER_ROW) {
                	int fila = e.getFirstRow();
                	
                    if (fila == 2 || fila == 3) {
                    	
                    }
                    else {
                    	String marca = tablaVehiculos.getValueAt(fila, 0).toString();
                        String modelo = tablaVehiculos.getValueAt(fila, 1).toString();
                        String matricula = tablaVehiculos.getValueAt(fila, 2).toString();
                        
                        DAOVehiculoImpl.getInstance().modificarVehiculo(marca, modelo, matricula);
                    }
                }
            }
        });
	 
	 
	 modelo.addColumn("Marca");

	 modelo.addColumn("Modelo");

	 modelo.addColumn("Matrícula");
	 
	 modelo.addColumn("Cliente");

	
    
   
	 Object[] registroLeido = new Object [4];
	 
	 for(Vehiculo vehiculo:lstVehiculos)

	 {	 

			registroLeido[0]= vehiculo.getMarca();

			registroLeido[1]= vehiculo.getModelo();

			registroLeido[2]=  vehiculo.getMatricula();
			
			registroLeido[3]=  DAOCliente.getInstance().getNombreCliente(vehiculo.getIdCliente());
	 



		 modelo.addRow(registroLeido);

	 }
	 
	 tablaVehiculos.setModel(modelo);
	}
	
	
	public static void cargarClientes(JComboBox<String> cbClientes) {
		List<Cliente> clientes = DAOCliente.getInstance().getClientes();
		
		DefaultComboBoxModel<String> comboBoxModel = (DefaultComboBoxModel<String>) cbClientes.getModel();
		comboBoxModel.removeAllElements();
		
		for (Cliente cliente : clientes) {
			cbClientes.addItem(cliente.getNombreUsuario());
		}
	}
	
	
	public static boolean insertarVehiculo( PanelCRUD frmVehiculo, JTable tablaVehiculos, String nombreUsuario)
	{ boolean insertado=false;
	Vehiculo vehiculo=new Vehiculo();
	 
	 
	 
	 vehiculo.setMarca(frmVehiculo.getTxtMarca().getText());

	 vehiculo.setModelo(frmVehiculo.getTxtModelo().getText());

	 vehiculo.setMatricula(frmVehiculo.getTxtMatricula().getText());
	 
		if (DAOVehiculoImpl.getInstance().insertarVehiculo(vehiculo, nombreUsuario)!=0)
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
	
	public static boolean eliminarCliente(String nombreUsuario, JComboBox<String> cbClientes, JTable tablaVehiculos) {
		boolean eliminado = false;
		
		if (DAOCliente.getInstance().eliminarCliente(nombreUsuario) != 0) {
			eliminado = true;
			cargarClientes(cbClientes);
			cargarTabla( tablaVehiculos);
		}
		
		return eliminado;
	}
	
	public static boolean eliminarVehiculo(JTable tablaVehiculos) {
		boolean eliminado = false;
		
		int fila = tablaVehiculos.getSelectedRow();
		
		String matricula = tablaVehiculos.getValueAt(fila, 2).toString();
		
		if (DAOVehiculoImpl.getInstance().eliminarVehiculo(matricula) != 0) {
			eliminado = true;
			cargarTabla( tablaVehiculos);
		}
		
		return eliminado;
	}
	
	
	

}
