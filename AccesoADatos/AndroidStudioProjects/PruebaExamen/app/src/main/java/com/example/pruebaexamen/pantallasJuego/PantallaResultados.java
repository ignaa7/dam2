package com.example.pruebaexamen.pantallasJuego;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;

import com.example.pruebaexamen.MainActivity;
import com.example.pruebaexamen.R;
import com.example.pruebaexamen.databinding.ActivityPantallaResultadosBinding;

public class PantallaResultados extends AppCompatActivity {
    private ActivityPantallaResultadosBinding binding;
    private boolean parar = false;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pantalla_resultados);

        binding = ActivityPantallaResultadosBinding.inflate(getLayoutInflater());
        View view = binding.getRoot();
        setContentView(view);

        SharedPreferences numeroAciertosPreferences = getSharedPreferences("numeroAciertosActual", Context.MODE_PRIVATE);
        int numeroAciertos = numeroAciertosPreferences.getInt("numeroAciertos", 0);

        SharedPreferences maxNumeroAciertosPreferences = getSharedPreferences("maximoNumeroAciertos", Context.MODE_PRIVATE);
        int maxNumAciertos = maxNumeroAciertosPreferences.getInt("maximoNumeroAciertos", 0);

        binding.txtMensaje.setText("Ha acertado " + numeroAciertos + " palabras.");

        if (numeroAciertos > maxNumAciertos) {
            binding.txtMensaje.setText(binding.txtMensaje.getText() + ". Enhorabuena, es su máxima puntuación");

            SharedPreferences.Editor editor = maxNumeroAciertosPreferences.edit();
            editor.putInt("maximoNumeroAciertos", numeroAciertos);
            editor.apply();
        }
    }

    public void volverInicio(View view) {
        Intent intent = new Intent(this, MainActivity.class);
        intent.setFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP | Intent.FLAG_ACTIVITY_SINGLE_TOP);
        parar = true;
        startActivity(intent);
        finish();
    }
}