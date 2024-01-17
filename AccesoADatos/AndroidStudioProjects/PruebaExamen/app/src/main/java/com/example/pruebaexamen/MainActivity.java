package com.example.pruebaexamen;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;

import com.example.pruebaexamen.pantallasConfiguracion.PantallaConfiguracion;
import com.example.pruebaexamen.pantallasJuego.PantallaJuego;
import com.example.pruebaexamen.pantallasPuntuaciones.PantallaPuntuaciones;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void irPantallaJuego(View view) {
        startActivity(new Intent(this, PantallaJuego.class));
    }
    public void irPantallaPuntuaciones(View view) {
        startActivity(new Intent(this, PantallaPuntuaciones.class));
    }
    public void irPantallaConfiguracion(View view) {
        startActivity(new Intent(this, PantallaConfiguracion.class));
    }

    public void salir(View view) {
        AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(this);

        alertDialogBuilder.setTitle("Salir");
        alertDialogBuilder.setMessage("¿Desea salir?");

        alertDialogBuilder.setPositiveButton("Salir", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                finishAffinity();
            }
        });

        alertDialogBuilder.setNegativeButton("Cancelar", new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {

            }
        });

        AlertDialog alertDialog = alertDialogBuilder.create();
        alertDialog.show();
    }
}