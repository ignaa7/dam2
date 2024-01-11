/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/GUIForms/JFrame.java to edit this template
 */
package com.mycompany.pruebapersonas;

import DAOs.DAOEmpresa;
import DAOs.DAOTrabajador;
import POJOs.Empresa;
import POJOs.Trabajador;
import java.sql.DriverManager;
import java.util.Collections;
import java.util.List;
import javax.swing.DefaultListModel;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;

/**
 *
 * @author ignac
 */
public class PantallaPersonas extends javax.swing.JFrame {

    private DAOEmpresa daoEmpresa;
    private DAOTrabajador daoTrabajador;

    private int codigoEmpresaEliminada;
    private String nombreEmpresaEliminada;

    /**
     * Creates new form PantallaPersonas
     */
    public PantallaPersonas() {
        initComponents();

        daoEmpresa = new DAOEmpresa();
        daoTrabajador = new DAOTrabajador();
        
        cargarLista();
        
        cargarTablaEmpresas();
        
        
        DefaultTableModel modelo = new DefaultTableModel();

        modelo.addColumn("Código empresa");
        modelo.addColumn("Nombre");
        modelo.addColumn("Sueldo");
        modelo.addColumn("Casado");
        
        tablaTrabajadores.setModel(modelo);
    }
    
    public PantallaPersonas(DAOTrabajador daoTrabajador) {
        this.daoTrabajador = daoTrabajador;
    }
    
    public void cargarLista() {
        try {
            List<Empresa> empresas = daoEmpresa.getEmpresas();
            DefaultListModel<String> listModel = new DefaultListModel<>();
            
            for (Empresa empresa : empresas) {
                listModel.addElement(empresa.getNombre());
            }
            
            lista.setModel(listModel);
        } catch (Exception e) {
        }
    }

    public void cargarTablaEmpresas() {
        try {
            lblError.setText("");
            
            List<Empresa> empresas = daoEmpresa.getEmpresas();
            DefaultTableModel modelo = new DefaultTableModel();

            modelo.addColumn("Código");
            modelo.addColumn("Nombre");

            Object[] registroLeido = new Object[2];

            for (Empresa empresa : empresas) {
                registroLeido[0] = empresa.getCodigo();
                registroLeido[1] = empresa.getNombre();

                modelo.addRow(registroLeido);
            }

            tablaEmpresas.setModel(modelo);
        } catch (Exception e) {
            lblError.setText(e.getMessage());
        }
    }

    public void cargarTablaTrabajadores() {
        int filaEmpresaSeleccionada = tablaEmpresas.getSelectedRow();

        if (filaEmpresaSeleccionada == -1) {
            lblError.setText("Ninguna empresa seleccionada");
        } else {
            lblError.setText("");
            try {
                int codigoEmpresaSeleccionada = Integer.parseInt(tablaEmpresas.getValueAt(filaEmpresaSeleccionada, 0).toString());
                List<Trabajador> trabajadores = daoTrabajador.getTrabajadores(codigoEmpresaSeleccionada);
                
                DefaultTableModel modelo = new DefaultTableModel();

                modelo.addColumn("Código empresa");
                modelo.addColumn("Nombre");
                modelo.addColumn("Sueldo");
                modelo.addColumn("Casado");
                
                Object[] registroLeido = new Object[4];

                for (Trabajador trabajador : trabajadores) {
                    registroLeido[0] = trabajador.getCodigoEmpresa();
                    registroLeido[1] = trabajador.getNombre();
                    registroLeido[2] = trabajador.getSueldo();
                    registroLeido[3] = trabajador.isCasado();

                    modelo.addRow(registroLeido);
                }
                
                tablaTrabajadores.setModel(modelo);
            } catch (Exception e) {
                lblError.setText(e.getMessage());
            }
        }
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        tablaTrabajadores = new javax.swing.JTable();
        jScrollPane2 = new javax.swing.JScrollPane();
        tablaEmpresas = new javax.swing.JTable();
        btnEliminarEmpresa = new javax.swing.JButton();
        btnDeshacer = new javax.swing.JButton();
        btnMostrarEmpresas = new javax.swing.JButton();
        btnComprobarCasados = new javax.swing.JButton();
        txtNombre = new javax.swing.JTextField();
        txtSueldo = new javax.swing.JTextField();
        cbCasado = new javax.swing.JCheckBox();
        lblNombre = new javax.swing.JLabel();
        lblSueldo = new javax.swing.JLabel();
        btnAgregarTrabajador = new javax.swing.JButton();
        lblError = new javax.swing.JLabel();
        j = new javax.swing.JScrollPane();
        lista = new javax.swing.JList<>();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        tablaTrabajadores.setModel(new javax.swing.table.DefaultTableModel(
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
        jScrollPane1.setViewportView(tablaTrabajadores);

        tablaEmpresas.setModel(new javax.swing.table.DefaultTableModel(
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
        tablaEmpresas.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                tablaEmpresasMouseClicked(evt);
            }
        });
        jScrollPane2.setViewportView(tablaEmpresas);

        btnEliminarEmpresa.setText("Eliminar empresa");
        btnEliminarEmpresa.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEliminarEmpresaActionPerformed(evt);
            }
        });

        btnDeshacer.setText("Deshacer empresa eliminada");
        btnDeshacer.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnDeshacerActionPerformed(evt);
            }
        });

        btnMostrarEmpresas.setText("Mostrar empresas ordenadas");
        btnMostrarEmpresas.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnMostrarEmpresasActionPerformed(evt);
            }
        });

        btnComprobarCasados.setText("Comprobar casados");
        btnComprobarCasados.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnComprobarCasadosActionPerformed(evt);
            }
        });

        cbCasado.setText("Casado");

        lblNombre.setText("Nombre");

        lblSueldo.setText("Sueldo");

        btnAgregarTrabajador.setText("Agregar trabajador");
        btnAgregarTrabajador.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAgregarTrabajadorActionPerformed(evt);
            }
        });

        lblError.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);

        lista.setModel(new javax.swing.AbstractListModel<String>() {
            String[] strings = { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5" };
            public int getSize() { return strings.length; }
            public String getElementAt(int i) { return strings[i]; }
        });
        j.setViewportView(lista);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(0, 0, Short.MAX_VALUE))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(btnMostrarEmpresas)
                            .addGroup(layout.createSequentialGroup()
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                    .addComponent(lblError, javax.swing.GroupLayout.PREFERRED_SIZE, 446, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(layout.createSequentialGroup()
                                        .addGap(85, 85, 85)
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                            .addComponent(btnEliminarEmpresa)
                                            .addComponent(btnDeshacer)))
                                    .addGroup(layout.createSequentialGroup()
                                        .addGap(84, 84, 84)
                                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                                .addComponent(btnComprobarCasados)
                                                .addGroup(layout.createSequentialGroup()
                                                    .addGap(17, 17, 17)
                                                    .addComponent(btnAgregarTrabajador)))
                                            .addGroup(layout.createSequentialGroup()
                                                .addComponent(cbCasado)
                                                .addGap(44, 44, 44))
                                            .addGroup(layout.createSequentialGroup()
                                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                                    .addComponent(lblSueldo)
                                                    .addComponent(lblNombre))
                                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                                                    .addComponent(txtSueldo)
                                                    .addComponent(txtNombre, javax.swing.GroupLayout.DEFAULT_SIZE, 102, Short.MAX_VALUE))
                                                .addGap(15, 15, 15)))))))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(j, javax.swing.GroupLayout.DEFAULT_SIZE, 94, Short.MAX_VALUE)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(14, 14, 14)
                        .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 185, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(36, 36, 36)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(j, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(btnEliminarEmpresa)
                                .addGap(18, 18, 18)
                                .addComponent(btnDeshacer)
                                .addGap(18, 18, 18)
                                .addComponent(btnMostrarEmpresas)
                                .addGap(18, 18, 18)
                                .addComponent(btnComprobarCasados)))))
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 7, Short.MAX_VALUE)
                        .addComponent(lblError, javax.swing.GroupLayout.PREFERRED_SIZE, 28, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 185, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(42, 42, 42))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(55, 55, 55)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(lblNombre)
                            .addComponent(txtNombre, javax.swing.GroupLayout.PREFERRED_SIZE, 22, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(txtSueldo, javax.swing.GroupLayout.PREFERRED_SIZE, 22, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(lblSueldo))
                        .addGap(18, 18, 18)
                        .addComponent(cbCasado)
                        .addGap(18, 18, 18)
                        .addComponent(btnAgregarTrabajador)
                        .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void tablaEmpresasMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_tablaEmpresasMouseClicked
        cargarTablaTrabajadores();
    }//GEN-LAST:event_tablaEmpresasMouseClicked

    private void btnEliminarEmpresaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnEliminarEmpresaActionPerformed
        int filaEmpresaSeleccionada = tablaEmpresas.getSelectedRow();
        
        if (filaEmpresaSeleccionada == -1) {
            lblError.setText("Ninguna empresa seleccionada");
            JOptionPane.showMessageDialog(this, "Ninguna empresa seleccionada");
        } else {
            lblError.setText("");
            
            int opcion = JOptionPane.showConfirmDialog(this, "¿Está seguro?", "Eliminar empresa", JOptionPane.YES_NO_CANCEL_OPTION);
            
            if (opcion == JOptionPane.YES_OPTION) {
                int codigoEmpresaSeleccionada = Integer.parseInt(tablaEmpresas.getValueAt(filaEmpresaSeleccionada, 0).toString());
                String nombreEmpresaSeleccionada = tablaEmpresas.getValueAt(filaEmpresaSeleccionada, 1).toString();

                int resultado = daoEmpresa.eliminarEmpresa(codigoEmpresaSeleccionada);

                if (resultado == 1) {
                    codigoEmpresaEliminada = codigoEmpresaSeleccionada;
                    nombreEmpresaEliminada = nombreEmpresaSeleccionada;

                    cargarTablaEmpresas();
                }
            }
        }
    }//GEN-LAST:event_btnEliminarEmpresaActionPerformed

    private void btnDeshacerActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnDeshacerActionPerformed
        if (codigoEmpresaEliminada != 0 && nombreEmpresaEliminada != "") {
            int resultado = daoEmpresa.insertarEmpresa(codigoEmpresaEliminada, nombreEmpresaEliminada);
        
            if (resultado == 1) {
                codigoEmpresaEliminada = 0;
                nombreEmpresaEliminada = "";

                cargarTablaEmpresas();
            }
        }
    }//GEN-LAST:event_btnDeshacerActionPerformed

    private void btnMostrarEmpresasActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnMostrarEmpresasActionPerformed
        List<Empresa> empresas = daoEmpresa.getEmpresas();
        
        //empresas.sort(null);
        Collections.sort(empresas);
        
        for (Empresa empresa : empresas) {
            System.out.println(empresa.toString());
        }
    }//GEN-LAST:event_btnMostrarEmpresasActionPerformed

    private void btnComprobarCasadosActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnComprobarCasadosActionPerformed
        int filaEmpresaSeleccionada = tablaEmpresas.getSelectedRow();
        
        if (filaEmpresaSeleccionada == -1) {
            JOptionPane.showMessageDialog(this, "Ninguna empresa seleccionada");
        } else {
            int codigoEmpresaSeleccionada = Integer.parseInt(tablaEmpresas.getValueAt(filaEmpresaSeleccionada, 0).toString());
            boolean hayCasados = comprobarCasados(codigoEmpresaSeleccionada);
            
            if (hayCasados) {
                JOptionPane.showMessageDialog(this, "Hay algún casado");
            } else {
                JOptionPane.showMessageDialog(this, "No hay ningún casado");
            }
        }
    }//GEN-LAST:event_btnComprobarCasadosActionPerformed

    public boolean comprobarCasados(int codigoEmpresaSeleccionada) {
        boolean hayCasado = daoTrabajador.comprobarCasados(codigoEmpresaSeleccionada);

        if (hayCasado) {
            return true;
        } else {
            return false;
        }
    }
    
    private void btnAgregarTrabajadorActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAgregarTrabajadorActionPerformed
        int filaEmpresaSeleccionada = tablaEmpresas.getSelectedRow();
        
        if (filaEmpresaSeleccionada == -1) {
            lblError.setText("Ninguna empresa seleccionada");
            JOptionPane.showMessageDialog(this, "Ninguna empresa seleccionada");
        } else {
            lblError.setText("");
            int codigoEmpresaSeleccionada = Integer.parseInt(tablaEmpresas.getValueAt(filaEmpresaSeleccionada, 0).toString());
            String nombre;
            double sueldo;
            boolean casado;
            
            try {
                nombre = txtNombre.getText();
                sueldo = Double.parseDouble(txtSueldo.getText());
                casado = cbCasado.isSelected();
                
                int resultado = daoTrabajador.insertarTrabajador(codigoEmpresaSeleccionada, nombre, sueldo, casado);
                
                if (resultado == 1) {
                    lblError.setText("Trabajador añadido correctamente");
                    
                    cargarTablaTrabajadores();
                } else {
                    lblError.setText("Error al añadir el trabajador");
                }
            } catch (Exception e) {
                lblError.setText(e.getMessage());
                System.out.println(e.getMessage());
            }
        }
    }//GEN-LAST:event_btnAgregarTrabajadorActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(PantallaPersonas.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(PantallaPersonas.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(PantallaPersonas.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(PantallaPersonas.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new PantallaPersonas().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnAgregarTrabajador;
    private javax.swing.JButton btnComprobarCasados;
    private javax.swing.JButton btnDeshacer;
    private javax.swing.JButton btnEliminarEmpresa;
    private javax.swing.JButton btnMostrarEmpresas;
    private javax.swing.JCheckBox cbCasado;
    private javax.swing.JScrollPane j;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JLabel lblError;
    private javax.swing.JLabel lblNombre;
    private javax.swing.JLabel lblSueldo;
    private javax.swing.JList<String> lista;
    private javax.swing.JTable tablaEmpresas;
    private javax.swing.JTable tablaTrabajadores;
    private javax.swing.JTextField txtNombre;
    private javax.swing.JTextField txtSueldo;
    // End of variables declaration//GEN-END:variables
}
