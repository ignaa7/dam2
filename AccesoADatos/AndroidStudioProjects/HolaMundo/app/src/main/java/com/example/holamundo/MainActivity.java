package com.example.holamundo;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Button btnSaludar2 = (Button) findViewById(R.id.btnSaludar2);

        btnSaludar2.setOnClickListener(this::mostrarSaludo2);
    }

    public void mostrarSaludo(View view) {
        TextView txtMensaje = findViewById(R.id.txtSaludo);

        txtMensaje.setText("Hola buenas");
    }

    public void mostrarSaludo2(View view) {
        TextView txtMensaje = findViewById(R.id.txtSaludo);

        txtMensaje.setText("Hasta luego");
    }
}