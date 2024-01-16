package com.example.pruebaexamen;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;

public class PantallaRespuesta extends AppCompatActivity {
    private EditText edtPalabra;
    private TextView txtPalabrasAcertadas;
    private List<String> palabras;
    private List<String> palabrasAcertadas = new ArrayList<>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pantalla_respuesta);

        edtPalabra = findViewById(R.id.edtPalabra);
        txtPalabrasAcertadas = findViewById(R.id.txtPalabrasAcertadas);

        SharedPreferences palabrasPreferences = getSharedPreferences("palabras", Context.MODE_PRIVATE);
        palabras = new ArrayList<>(palabrasPreferences.getStringSet("palabras", null));
    }

    public void comprobarPalabra(View view) {
        String palabra = edtPalabra.getText().toString();

        if (!palabra.isEmpty()) {
            if (palabras.contains(palabra) && !palabrasAcertadas.contains(palabra)) {
                palabrasAcertadas.add(palabra);
                txtPalabrasAcertadas.setText(txtPalabrasAcertadas.getText() + ", " + palabra);
            }
        }
    }
}