/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/GUIForms/JFrame.java to edit this template
 */
package com.mycompany.cliente;

import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.ObjectMapper;
import java.awt.event.KeyEvent;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
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
    private static Socket socket;
    private static DataOutputStream dataOutputStream;

    public Cliente(String nombre) {
        initComponents();
        setFocusable(true);
        lblNombre.setText(nombre);
    }
    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        lblNombre = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                formKeyPressed(evt);
            }
        });

        lblNombre.setText("jLabel1");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(268, 268, 268)
                .addComponent(lblNombre)
                .addContainerGap(282, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(24, 24, 24)
                .addComponent(lblNombre)
                .addContainerGap(388, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void formKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_formKeyPressed
        int keyCode = evt.getKeyCode();
        
        if (keyCode == KeyEvent.VK_RIGHT) {
            try {
                dataOutputStream.writeUTF("derecha");
            } catch (IOException ex) {
                Logger.getLogger(Cliente.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
        else if (keyCode == KeyEvent.VK_LEFT) {
            try {
                dataOutputStream.writeUTF("izquierda");
            } catch (IOException ex) {
                Logger.getLogger(Cliente.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
    }//GEN-LAST:event_formKeyPressed

    public static void main(String args[]) throws IOException, ClassNotFoundException {   
        
        socket = new Socket("localhost", 2000);
        dataOutputStream = new DataOutputStream(socket.getOutputStream());
        
        DataInputStream dataInputStream = new DataInputStream(socket.getInputStream());
        String nombre = dataInputStream.readUTF();
        
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Cliente(nombre).setVisible(true);
            }
        });
        
        ejecutar();
    }
    
    private static void ejecutar() throws IOException, ClassNotFoundException {
                ArrayList<Jugador> jugadores = null;

                boolean fin = false;
                int idGanador = 0;
                
		while (!fin) {
                    if (!socket.isClosed()) {
                        DataInputStream dataInputStream = new DataInputStream(socket.getInputStream());
                        String json = dataInputStream.readUTF();
                        
                        ObjectMapper objectMapper = new ObjectMapper();
                        jugadores = objectMapper.readValue(json, new TypeReference<ArrayList<Jugador>>() {});
                    }
                    
                    for (Jugador jugador : jugadores) {
                        System.out.println(jugador.toString());
                        if (jugador.getPuntuacion() == 5) {
                            fin = true;
                            idGanador = jugador.getId();
                        }
                    }
                    System.out.println("\n");
		}
                
                System.out.println("Ha ganado el Jugador " + idGanador);
                
                dataOutputStream.close();
		socket.close();
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel lblNombre;
    // End of variables declaration//GEN-END:variables
}
