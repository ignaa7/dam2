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
public class Cliente extends javax.swing.JFrame implements Runnable{
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
        lblJugador1 = new javax.swing.JLabel();
        lblJugador4 = new javax.swing.JLabel();
        lblJugador3 = new javax.swing.JLabel();
        lblJugador2 = new javax.swing.JLabel();
        lblResultado = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                formKeyPressed(evt);
            }
        });

        lblNombre.setFont(new java.awt.Font("Segoe UI", 0, 18)); // NOI18N
        lblNombre.setText("jLabel1");

        lblJugador1.setBackground(new java.awt.Color(255, 0, 0));
        lblJugador1.setFont(new java.awt.Font("Segoe UI", 0, 48)); // NOI18N
        lblJugador1.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lblJugador1.setText("1");

        lblJugador4.setBackground(new java.awt.Color(204, 204, 0));
        lblJugador4.setFont(new java.awt.Font("Segoe UI", 0, 48)); // NOI18N
        lblJugador4.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lblJugador4.setText("4");

        lblJugador3.setBackground(new java.awt.Color(153, 255, 153));
        lblJugador3.setFont(new java.awt.Font("Segoe UI", 0, 48)); // NOI18N
        lblJugador3.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lblJugador3.setText("3");

        lblJugador2.setBackground(new java.awt.Color(51, 153, 255));
        lblJugador2.setFont(new java.awt.Font("Segoe UI", 0, 48)); // NOI18N
        lblJugador2.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lblJugador2.setText("2");

        lblResultado.setFont(new java.awt.Font("Segoe UI", 0, 48)); // NOI18N
        lblResultado.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(268, 268, 268)
                        .addComponent(lblNombre))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(230, 230, 230)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(lblJugador2, javax.swing.GroupLayout.PREFERRED_SIZE, 125, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(lblJugador1, javax.swing.GroupLayout.PREFERRED_SIZE, 125, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(lblJugador3, javax.swing.GroupLayout.PREFERRED_SIZE, 125, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(lblJugador4, javax.swing.GroupLayout.PREFERRED_SIZE, 125, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(lblResultado, javax.swing.GroupLayout.PREFERRED_SIZE, 125, javax.swing.GroupLayout.PREFERRED_SIZE))))
                .addGap(51, 232, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(24, 24, 24)
                .addComponent(lblNombre)
                .addGap(18, 18, 18)
                .addComponent(lblJugador1, javax.swing.GroupLayout.PREFERRED_SIZE, 55, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(lblJugador2, javax.swing.GroupLayout.PREFERRED_SIZE, 55, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(lblJugador3, javax.swing.GroupLayout.PREFERRED_SIZE, 55, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(lblJugador4, javax.swing.GroupLayout.PREFERRED_SIZE, 55, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(lblResultado, javax.swing.GroupLayout.PREFERRED_SIZE, 55, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(14, Short.MAX_VALUE))
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
                Cliente cliente = new Cliente(nombre);
                cliente.setVisible(true);
                new Thread(cliente).start();
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel lblJugador1;
    private javax.swing.JLabel lblJugador2;
    private javax.swing.JLabel lblJugador3;
    private javax.swing.JLabel lblJugador4;
    private javax.swing.JLabel lblNombre;
    private javax.swing.JLabel lblResultado;
    // End of variables declaration//GEN-END:variables

    @Override
    public void run() {
        ArrayList<Jugador> jugadores = null;

                boolean fin = false;
                int idGanador = 0;
                
		while (!fin) {
                    if (!socket.isClosed()) {
                        try {
                            DataInputStream dataInputStream = new DataInputStream(socket.getInputStream());
                            String json = dataInputStream.readUTF();
                        
                            ObjectMapper objectMapper = new ObjectMapper();
                            jugadores = objectMapper.readValue(json, new TypeReference<ArrayList<Jugador>>() {});
                        } catch (Exception e) {
                        }
                    }
                    
                    for (int i = 0; i < jugadores.size(); i++) {
                        switch (i) {
                            case 0:
                                lblJugador1.setBounds(jugadores.get(i).getPosicion(), lblJugador1.getY(), lblJugador1.getWidth(), lblJugador1.getHeight());
                                break;
                            case 1:
                                lblJugador2.setBounds(jugadores.get(i).getPosicion(), lblJugador2.getY(), lblJugador2.getWidth(), lblJugador2.getHeight());
                                break;
                            case 2:
                                lblJugador3.setBounds(jugadores.get(i).getPosicion(), lblJugador3.getY(), lblJugador3.getWidth(), lblJugador3.getHeight());
                                break;
                            case 3:
                                lblJugador4.setBounds(jugadores.get(i).getPosicion(), lblJugador4.getY(), lblJugador4.getWidth(), lblJugador4.getHeight());
                                break;
                            default:
                                break;
                        }
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
                
                try {
                    dataOutputStream.close();
                    socket.close();
                    } catch (Exception e) {
                      }
    }
}
