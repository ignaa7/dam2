/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/GUIForms/JFrame.java to edit this template
 */
package com.mycompany.cliente;

import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.ObjectMapper;
import java.awt.Image;
import java.awt.event.KeyEvent;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.ImageIcon;
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
        
        lblMetaIzquierda.setOpaque(true);
        lblMetaDerecha.setOpaque(true);
        
        setLocationRelativeTo(null);
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
        lblMetaIzquierda = new javax.swing.JLabel();
        lblMetaDerecha = new javax.swing.JLabel();
        lblPuntosJugador1 = new javax.swing.JLabel();
        lblPuntosJugador2 = new javax.swing.JLabel();
        lblPuntosJugador3 = new javax.swing.JLabel();
        lblPuntosJugador4 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                formKeyPressed(evt);
            }
        });

        lblNombre.setFont(new java.awt.Font("Segoe UI", 0, 18)); // NOI18N
        lblNombre.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);

        lblJugador1.setBackground(new java.awt.Color(255, 0, 0));
        lblJugador1.setFont(new java.awt.Font("Segoe UI", 0, 48)); // NOI18N
        lblJugador1.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);

        lblJugador4.setBackground(new java.awt.Color(204, 204, 0));
        lblJugador4.setFont(new java.awt.Font("Segoe UI", 0, 48)); // NOI18N
        lblJugador4.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);

        lblJugador3.setBackground(new java.awt.Color(153, 255, 153));
        lblJugador3.setFont(new java.awt.Font("Segoe UI", 0, 48)); // NOI18N
        lblJugador3.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);

        lblJugador2.setBackground(new java.awt.Color(51, 153, 255));
        lblJugador2.setFont(new java.awt.Font("Segoe UI", 0, 48)); // NOI18N
        lblJugador2.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);

        lblResultado.setFont(new java.awt.Font("Segoe UI", 0, 48)); // NOI18N
        lblResultado.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);

        lblMetaIzquierda.setBackground(new java.awt.Color(255, 0, 0));

        lblMetaDerecha.setBackground(new java.awt.Color(255, 0, 0));

        lblPuntosJugador1.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);

        lblPuntosJugador2.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);

        lblPuntosJugador3.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);

        lblPuntosJugador4.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(lblMetaIzquierda, javax.swing.GroupLayout.PREFERRED_SIZE, 9, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addGap(215, 215, 215)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(lblNombre, javax.swing.GroupLayout.PREFERRED_SIZE, 125, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(lblJugador2, javax.swing.GroupLayout.PREFERRED_SIZE, 125, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(lblJugador3, javax.swing.GroupLayout.PREFERRED_SIZE, 125, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(lblJugador1, javax.swing.GroupLayout.PREFERRED_SIZE, 125, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(lblJugador4, javax.swing.GroupLayout.PREFERRED_SIZE, 125, javax.swing.GroupLayout.PREFERRED_SIZE)))
                            .addGroup(layout.createSequentialGroup()
                                .addGap(255, 255, 255)
                                .addComponent(lblPuntosJugador4, javax.swing.GroupLayout.PREFERRED_SIZE, 57, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(layout.createSequentialGroup()
                                .addGap(253, 253, 253)
                                .addComponent(lblPuntosJugador3, javax.swing.GroupLayout.PREFERRED_SIZE, 56, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(layout.createSequentialGroup()
                                .addGap(256, 256, 256)
                                .addComponent(lblPuntosJugador2, javax.swing.GroupLayout.PREFERRED_SIZE, 56, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(layout.createSequentialGroup()
                                .addGap(257, 257, 257)
                                .addComponent(lblPuntosJugador1, javax.swing.GroupLayout.PREFERRED_SIZE, 55, javax.swing.GroupLayout.PREFERRED_SIZE)))
                        .addGap(0, 0, Short.MAX_VALUE))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(lblResultado, javax.swing.GroupLayout.PREFERRED_SIZE, 560, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addGap(18, 18, 18)
                .addComponent(lblMetaDerecha, javax.swing.GroupLayout.PREFERRED_SIZE, 9, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(lblNombre, javax.swing.GroupLayout.PREFERRED_SIZE, 37, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(10, 10, 10)
                        .addComponent(lblPuntosJugador1, javax.swing.GroupLayout.PREFERRED_SIZE, 16, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(lblJugador1, javax.swing.GroupLayout.PREFERRED_SIZE, 55, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(lblPuntosJugador2, javax.swing.GroupLayout.PREFERRED_SIZE, 16, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(lblJugador2, javax.swing.GroupLayout.PREFERRED_SIZE, 55, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(lblPuntosJugador3, javax.swing.GroupLayout.PREFERRED_SIZE, 16, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(lblJugador3, javax.swing.GroupLayout.PREFERRED_SIZE, 55, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(lblPuntosJugador4, javax.swing.GroupLayout.PREFERRED_SIZE, 16, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(lblJugador4, javax.swing.GroupLayout.PREFERRED_SIZE, 55, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(13, 13, 13)
                        .addComponent(lblResultado, javax.swing.GroupLayout.PREFERRED_SIZE, 68, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(lblMetaIzquierda, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(lblMetaDerecha, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void formKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_formKeyPressed
        int keyCode = evt.getKeyCode();
        
        if (keyCode == KeyEvent.VK_RIGHT) {
            try {
                dataOutputStream.writeInt(0);
            } catch (IOException ex) {
                Logger.getLogger(Cliente.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
        else if (keyCode == KeyEvent.VK_LEFT) {
            try {
                dataOutputStream.writeInt(1);
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
    private javax.swing.JLabel lblMetaDerecha;
    private javax.swing.JLabel lblMetaIzquierda;
    private javax.swing.JLabel lblNombre;
    private javax.swing.JLabel lblPuntosJugador1;
    private javax.swing.JLabel lblPuntosJugador2;
    private javax.swing.JLabel lblPuntosJugador3;
    private javax.swing.JLabel lblPuntosJugador4;
    private javax.swing.JLabel lblResultado;
    // End of variables declaration//GEN-END:variables

    @Override
    public void run() {
        ArrayList<Jugador> jugadores = new ArrayList<>();
        final int posicionInicial = 230;
        
        ImageIcon icon1 = new ImageIcon("resources\\car1.png");
        Image img1 = icon1.getImage();
        Image imgScale1 = img1.getScaledInstance(lblJugador1.getWidth(), lblJugador1.getHeight(), Image.SCALE_SMOOTH);
        ImageIcon scaledIcon1 = new ImageIcon(imgScale1);
        lblJugador1.setIcon(scaledIcon1);
        lblJugador1.setVisible(false);
        
        ImageIcon icon2 = new ImageIcon("resources\\car2.png");
        Image img2 = icon2.getImage();
        Image imgScale2 = img2.getScaledInstance(lblJugador2.getWidth(), lblJugador2.getHeight(), Image.SCALE_SMOOTH);
        ImageIcon scaledIcon2 = new ImageIcon(imgScale2);
        lblJugador2.setIcon(scaledIcon2);
        lblJugador2.setVisible(false);
        
        ImageIcon icon3 = new ImageIcon("resources\\car3.png");
        Image img3 = icon3.getImage();
        Image imgScale3 = img3.getScaledInstance(lblJugador3.getWidth(), lblJugador3.getHeight(), Image.SCALE_SMOOTH);
        ImageIcon scaledIcon3 = new ImageIcon(imgScale3);
        lblJugador3.setIcon(scaledIcon3);
        lblJugador3.setVisible(false);
        
        ImageIcon icon4 = new ImageIcon("resources\\car4.png");
        Image img4 = icon4.getImage();
        Image imgScale4 = img4.getScaledInstance(lblJugador4.getWidth(), lblJugador4.getHeight(), Image.SCALE_SMOOTH);
        ImageIcon scaledIcon4 = new ImageIcon(imgScale4);
        lblJugador4.setIcon(scaledIcon4);
        lblJugador4.setVisible(false);

        boolean fin = false;
        int idGanador = 0;
                
	while (!fin) {
            if (!socket.isClosed()) {
                try {
                    DataInputStream dataInputStream = new DataInputStream(socket.getInputStream());
                    String json = dataInputStream.readUTF();
                        
                    ObjectMapper objectMapper = new ObjectMapper();
                    jugadores = objectMapper.readValue(json, new TypeReference<ArrayList<Jugador>>() {});
                } catch (IOException e) {
                }
            }
                    
            for (int i = 0; i < jugadores.size(); i++) {
                switch (i) {
                    case 0 -> {
                        lblJugador1.setBounds(posicionInicial + jugadores.get(i).getPosicion(), lblJugador1.getY(), lblJugador1.getWidth(), lblJugador1.getHeight());
                        lblJugador1.setVisible(true);
                        lblPuntosJugador1.setText("Puntos: " + jugadores.get(i).getPuntuacion());
                    }
                    case 1 -> {
                        lblJugador2.setBounds(posicionInicial + jugadores.get(i).getPosicion(), lblJugador2.getY(), lblJugador2.getWidth(), lblJugador2.getHeight());
                        lblJugador2.setVisible(true);
                        lblPuntosJugador2.setText("Puntos: " + jugadores.get(i).getPuntuacion());
                    }
                    case 2 -> {
                        lblJugador3.setBounds(posicionInicial + jugadores.get(i).getPosicion(), lblJugador3.getY(), lblJugador3.getWidth(), lblJugador3.getHeight());
                        lblJugador3.setVisible(true);
                        lblPuntosJugador3.setText("Puntos: " + jugadores.get(i).getPuntuacion());
                    }
                    case 3 -> {
                        lblJugador4.setBounds(posicionInicial + jugadores.get(i).getPosicion(), lblJugador4.getY(), lblJugador4.getWidth(), lblJugador4.getHeight());
                        lblJugador4.setVisible(true);
                        lblPuntosJugador4.setText("Puntos: " + jugadores.get(i).getPuntuacion());
                    }
                    default -> {
                    }
                }
                
                if (jugadores.get(i).getPuntuacion() == 5) {
                    fin = true;
                    idGanador = jugadores.get(i).getId();
                }
            }
	}
        
        lblResultado.setText("Ha ganado el Jugador " + idGanador);
                
        try {
            dataOutputStream.close();
            socket.close();
        } catch (Exception e) {
        }
    }
}
