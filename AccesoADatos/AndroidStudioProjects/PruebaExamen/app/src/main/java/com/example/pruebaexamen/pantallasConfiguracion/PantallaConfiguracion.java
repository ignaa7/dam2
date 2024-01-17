package com.example.pruebaexamen.pantallasConfiguracion;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

import com.example.pruebaexamen.MainActivity;
import com.example.pruebaexamen.R;
import com.example.pruebaexamen.databinding.ActivityPantallaConfiguracionBinding;
import com.example.pruebaexamen.pantallasJuego.PantallaJuego;

public class PantallaConfiguracion extends AppCompatActivity {
    private ActivityPantallaConfiguracionBinding binding;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pantalla_configuracion);

        binding = ActivityPantallaConfiguracionBinding.inflate(getLayoutInflater());
        View view = binding.getRoot();
        setContentView(view);
    }

    public void irPantallaElegirDificultad(View view) {
        startActivity(new Intent(this, PantallaElegirDificultad.class));
    }
    public void irPantallaListarPalabras(View view) {
        startActivity(new Intent(this, PantallaListarPalabras.class));
    }
    public void volverInicio(View view) {
        Intent intent = new Intent(this, MainActivity.class);
        intent.setFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP | Intent.FLAG_ACTIVITY_SINGLE_TOP);
        startActivity(intent);
        finish();
    }
}