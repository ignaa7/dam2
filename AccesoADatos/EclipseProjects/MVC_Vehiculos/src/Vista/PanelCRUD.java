package Vista;


import javax.swing.GroupLayout;
import javax.swing.LayoutStyle;

import Controller.ControllerCRUD;
import DAOs.DAOCliente;

import javax.swing.GroupLayout.Alignment;
import javax.swing.LayoutStyle.ComponentPlacement;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JButton;
import javax.swing.JComboBox;
import java.awt.event.ActionListener;
import java.awt.Dimension;
import java.awt.event.ActionEvent;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Luis
 */
public class PanelCRUD extends javax.swing.JPanel {
	
	private JComboBox<String> cbClientes;

    private ControllerCRUD controller;
    
       public PanelCRUD() {
        initComponents();
        this.inicializarPanel();
        this.setPreferredSize(new Dimension(1000, 392));
        
        ControllerCRUD.cargarTabla(tablaVehiculos);
        add(jScrollPane1);
        add(jLabel1);
        add(jLabel2);
        add(jLabelMatricula);
        add(txtModelo);
        add(txtMarca);
        add(txtMatricula);
        add(btRegistrar);
        setLayout(null);
        add(jScrollPane1);
        add(jLabel1);
        add(jLabel2);
        add(jLabelMatricula);
        add(txtModelo);
        add(txtMarca);
        add(txtMatricula);
        add(btRegistrar);
        
        txtNombreUsuario = new JTextField();
        txtNombreUsuario.setBounds(584, 144, 230, 20);
        add(txtNombreUsuario);
        txtNombreUsuario.setColumns(10);
        
        JButton btnAgregarUsuario = new JButton("Agregar usuario");
        btnAgregarUsuario.addActionListener(new ActionListener() {
        	public void actionPerformed(ActionEvent e) {
        		if (!txtNombreUsuario.getText().isEmpty()) {
        			ControllerCRUD.insertarCliente(txtNombreUsuario.getText(), cbClientes);
        			txtNombreUsuario.setText("");
        		}
        	}
        });
        btnAgregarUsuario.setBounds(584, 193, 164, 23);
        add(btnAgregarUsuario);
        
        JLabel lblNombreUsuario = new JLabel("Nombre de usuario");
        lblNombreUsuario.setBounds(432, 147, 147, 14);
        add(lblNombreUsuario);
        
        cbClientes = new JComboBox();
        cbClientes.setBounds(367, 41, 216, 22);
        add(cbClientes);
        
        JLabel lblCliente = new JLabel("Cliente");
        lblCliente.setBounds(325, 45, 46, 14);
        add(lblCliente);
        
        
        controller.cargarTabla(tablaVehiculos);
        controller.cargarClientes(cbClientes);
        
        JButton btnEliminarCliente = new JButton("Eliminar cliente");
        btnEliminarCliente.addActionListener(new ActionListener() {
        	public void actionPerformed(ActionEvent e) {
        		ControllerCRUD.eliminarCliente(cbClientes.getSelectedItem().toString(), cbClientes, tablaVehiculos);
        	}
        });
        btnEliminarCliente.setBounds(621, 41, 127, 23);
        add(btnEliminarCliente);
        
        btnEliminarVehiculo = new JButton("Eliminar vehículo");
        btnEliminarVehiculo.addActionListener(new ActionListener() {
        	public void actionPerformed(ActionEvent e) {
        		ControllerCRUD.eliminarVehiculo(tablaVehiculos);
        	}
        });
        btnEliminarVehiculo.setBounds(395, 277, 134, 23);
        add(btnEliminarVehiculo);
        
    }

 
private void txtModeloActionPerformed(java.awt.event.ActionEvent evt) {										
 
	 // TODO add your handling code here:
 
}										
 
 
 
private void btRegistrarActionPerformed(java.awt.event.ActionEvent evt) {										
 
	

  //  DAOVehiculoImpl.getInstance().insertarVehiculo(new Vehiculo(txtMatricula.getText(), ))
	
	if (!txtMarca.getText().isEmpty() && !txtModelo.getText().isEmpty() && !txtMatricula.getText().isEmpty()) {
		ControllerCRUD.insertarVehiculo(this, tablaVehiculos, cbClientes.getSelectedItem().toString());
		txtMarca.setText("");
		txtModelo.setText("");
		txtMatricula.setText("");
	}

    

 
 
 
}										
 
 
 
public javax.swing.JTextField getTxtMatricula() {
	return txtMatricula;
}



public void setTxtMatricula(javax.swing.JTextField txtMatricula) {
	this.txtMatricula = txtMatricula;
}



public javax.swing.JTextField getTxtMarca() {
	return txtMarca;
}



public void setTxtMarca(javax.swing.JTextField txtMarca) {
	this.txtMarca = txtMarca;
}



public javax.swing.JTextField getTxtModelo() {
	return txtModelo;
}



public void setTxtModelo(javax.swing.JTextField txtModelo) {
	this.txtModelo = txtModelo;
}
 
private javax.swing.JButton btRegistrar;
 
private javax.swing.JLabel jLabel1;
 
private javax.swing.JLabel jLabel2;
 
private javax.swing.JLabel jLabelMatricula;
 
private javax.swing.JScrollPane jScrollPane1;
 
private javax.swing.JTable tablaVehiculos;
 
private javax.swing.JTextField txtMatricula;
 
private javax.swing.JTextField txtMarca;
 
private javax.swing.JTextField txtModelo;
private JTextField txtNombreUsuario;
private JButton btnEliminarVehiculo;
    /**
     * Creates new form PanelCRUD
     */
 
    
    
    
    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {
    }// </editor-fold>//GEN-END:initComponents


    // Variables declaration - do not modify//GEN-BEGIN:variables
    // End of variables declaration//GEN-END:variables


private void inicializarPanel() {
 
 
 
	 jLabel1 = new javax.swing.JLabel();
	 jLabel1.setBounds(10, 14, 65, 14);
 
	 jScrollPane1 = new javax.swing.JScrollPane();
	 jScrollPane1.setBounds(10, 196, 375, 181);
 
	 tablaVehiculos = new javax.swing.JTable();
 
	 txtMarca = new javax.swing.JTextField();
	 txtMarca.setBounds(80, 11, 196, 20);
 
	 txtModelo = new javax.swing.JTextField();
	 txtModelo.setBounds(80, 40, 210, 25);
 
	 jLabel2 = new javax.swing.JLabel();
	 jLabel2.setBounds(10, 45, 79, 14);
 
	 jLabelMatricula = new javax.swing.JLabel();
	 jLabelMatricula.setBounds(10, 79, 93, 14);
 
	 txtMatricula = new javax.swing.JTextField();
	 txtMatricula.setBounds(80, 76, 196, 20);
 
	 btRegistrar = new javax.swing.JButton();
	 btRegistrar.setBounds(103, 121, 163, 23);
 
 
 
	 
 
 
 
	 jLabel1.setText("Marca");
 
 
 
	 tablaVehiculos.setModel(new javax.swing.table.DefaultTableModel(
 
		 new Object [][] {
 
			 {null, null, null, null},
 
			 {null, null, null, null},
 
			 {null, null, null, null},
 
			 {null, null, null, null}
 
		 },
 
		 new String [] {
 
			 "Title 1", "Title 2", "Title 3", "Title 4"
 
		 }
 
	 ));
 
	 jScrollPane1.setViewportView(tablaVehiculos);
 
 
 
	 txtMarca.setName("marca"); // NOI18N
 
 
 
	 txtModelo.setToolTipText("");
 
	 txtModelo.setName("modelo"); // NOI18N
 
	 txtModelo.addActionListener(new java.awt.event.ActionListener() {
 
		 public void actionPerformed(java.awt.event.ActionEvent evt) {
 
			 txtModeloActionPerformed(evt);
 
		 }
 
	 });
 
 
 
	 jLabel2.setText("Modelo");
 
 
 
	 jLabelMatricula.setText("Matrícula");
 
 
 
	 txtMatricula.setToolTipText("");
 
 
 
	 btRegistrar.setText("Registrar vehículo");
 
	 btRegistrar.setActionCommand("btRegistrar");
 
	 btRegistrar.setName("btRegistrar"); // NOI18N
 
	 btRegistrar.addActionListener(new java.awt.event.ActionListener() {
 
		 public void actionPerformed(java.awt.event.ActionEvent evt) {
 
			 btRegistrarActionPerformed(evt);
 
		 }
 
	 });
	 setLayout(null);
 
 
 
	 
 
}// </editor-fold>	
}
