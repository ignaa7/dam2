/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/GUIForms/JFrame.java to edit this template
 */
package com.mycompany.cliente;

import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.ObjectMapper;
import java.io.BufferedReader;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.ObjectInputStream;
import java.io.PrintWriter;
import java.net.Socket;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JFrame;
import modelo.Jugador;

/**
 *
 * @author dam
 */
public class Cliente extends javax.swing.JFrame {
    
    private JFrame jFrame;
    private static Socket socket;
    private static DataOutputStream dataOutputStream;

    /**
     * Creates new form Cliente
     */
    public Cliente() {
        jFrame = this.jFrame;
        initComponents();
    }
    

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        lblNombre = new javax.swing.JLabel();
        jButton1 = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        lblNombre.setText("jLabel1");

        jButton1.setText("jButton1");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(157, 157, 157)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jButton1)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(21, 21, 21)
                        .addComponent(lblNombre)))
                .addContainerGap(164, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(23, 23, 23)
                .addComponent(lblNombre)
                .addGap(78, 78, 78)
                .addComponent(jButton1)
                .addContainerGap(156, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        try {
            dataOutputStream.writeUTF("a");
        } catch (IOException ex) {
            Logger.getLogger(Cliente.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_jButton1ActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) throws IOException, ClassNotFoundException {        
        

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Cliente().setVisible(true);
            }
        });
        
        socket = new Socket("localhost", 2000);
        dataOutputStream = new DataOutputStream(socket.getOutputStream());
        
        ejecutar();
    }
    
    private static void ejecutar() throws IOException, ClassNotFoundException {
                ArrayList<Jugador> jugadores = null;
                
                //HiloCliente hilo = new HiloCliente(socket, jugadores);

                boolean fin = false;
                
		while (!fin) {
                    DataInputStream dataInputStream = new DataInputStream(socket.getInputStream());
                    String json = dataInputStream.readUTF();
                    
                    ObjectMapper objectMapper = new ObjectMapper();
                    jugadores = objectMapper.readValue(json, new TypeReference<ArrayList<Jugador>>() {});
                    
                    for (Jugador jugador : jugadores) {
                        System.out.println(jugador.toString());
                        if (jugador.getPuntuacion() == 5) fin = true;
                    }
                    System.out.println("\n");
		}
                
		//objectInputStream.close();
                dataOutputStream.close();
		System.out.println("Fin del envío... ");
		socket.close();
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel lblNombre;
    // End of variables declaration//GEN-END:variables
}
