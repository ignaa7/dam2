package com.example.pruebaexamen.pantallasConfiguracion;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.RadioGroup;

import com.example.pruebaexamen.MainActivity;
import com.example.pruebaexamen.R;
import com.example.pruebaexamen.databinding.ActivityPantallaConfiguracionBinding;
import com.example.pruebaexamen.databinding.ActivityPantallaElegirDificultadBinding;

import java.util.HashSet;

public class PantallaElegirDificultad extends AppCompatActivity {
    private ActivityPantallaElegirDificultadBinding binding;
    private SharedPreferences dificultadPreferences;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pantalla_elegir_dificultad);

        binding = ActivityPantallaElegirDificultadBinding.inflate(getLayoutInflater());
        View view = binding.getRoot();
        setContentView(view);

        dificultadPreferences = getSharedPreferences("dificultad", Context.MODE_PRIVATE);

        binding.rgDificultades.setOnCheckedChangeListener(new RadioGroup.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(RadioGroup radioGroup, int id) {
                String dificultadElegida = "";

                if (id == binding.rbFacil.getId()) {
                    dificultadElegida = "facil";
                } else if (id == binding.rbMedio.getId()) {
                    dificultadElegida = "medio";
                } else if (id == binding.rbDificil.getId()) {
                    dificultadElegida = "dificil";
                }

                if (!dificultadElegida.isEmpty()) {
                    SharedPreferences.Editor editor = dificultadPreferences.edit();
                    editor.putString("dificultad", dificultadElegida);
                    editor.apply();
                }
            }
        });
    }

    @Override
    protected void onResume() {
        super.onResume();

        String dificultad = dificultadPreferences.getString("dificultad", "dificil");

        if (dificultad.equals("dificil")) {
            binding.rbDificil.setChecked(true);
        } else if (dificultad.equals("medio")) {
            binding.rbMedio.setChecked(true);
        } else if (dificultad.equals("facil")) {
            binding.rbFacil.setChecked(true);
        }
    }

    public void volver(View view) {
        finish();
    }

    public void volverInicio(View view) {
        Intent intent = new Intent(this, MainActivity.class);
        intent.setFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP | Intent.FLAG_ACTIVITY_SINGLE_TOP);
        startActivity(intent);
        finish();
    }
}