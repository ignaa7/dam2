package com.example.pruebaexamen.pantallasJuego;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.os.Handler;
import android.os.Looper;
import android.view.View;

import com.example.pruebaexamen.MainActivity;
import com.example.pruebaexamen.R;
import com.example.pruebaexamen.databinding.ActivityPantallaRespuestaBinding;

import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class PantallaRespuesta extends AppCompatActivity {
    private ActivityPantallaRespuestaBinding binding;
    private List<String> palabras;
    private List<String> palabrasAcertadas = new ArrayList<>();
    private boolean parar = false;

    // always instance SharedPreferences inside a method
    SharedPreferences numeroAciertosPreferences;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pantalla_respuesta);

        binding = ActivityPantallaRespuestaBinding.inflate(getLayoutInflater());
        View view = binding.getRoot();
        setContentView(view);

        numeroAciertosPreferences = getSharedPreferences("numeroAciertosActual", Context.MODE_PRIVATE);

        // SharedPreferences get values
        SharedPreferences palabrasPreferences = getSharedPreferences("palabras", Context.MODE_PRIVATE);
        palabras = new ArrayList<>(palabrasPreferences.getStringSet("palabras", null));

        gestionarTiempo();
    }

    public void volverInicio(View view) {
        Intent intent = new Intent(this, MainActivity.class);
        intent.setFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP | Intent.FLAG_ACTIVITY_SINGLE_TOP);
        parar = true;
        startActivity(intent);
        finish();
    }

    public void comprobarPalabra(View view) {
        String palabra = binding.edtPalabra.getText().toString();

        if (!palabra.isEmpty()) {
            if (palabras.contains(palabra) && !palabrasAcertadas.contains(palabra)) {
                palabrasAcertadas.add(palabra);
                if (binding.txtPalabrasAcertadas.getText().length() == 0) {
                    binding.txtPalabrasAcertadas.setText(palabra);
                } else {
                    binding.txtPalabrasAcertadas.setText(binding.txtPalabrasAcertadas.getText() + ", " + palabra);
                }

                binding.pbProgreso.setProgress((int)((float)palabrasAcertadas.size() / palabras.size() * 100));
            }
        }

        if (palabrasAcertadas.size() == palabras.size()) {
            SharedPreferences.Editor editor = numeroAciertosPreferences.edit();
            editor.putInt("numeroAciertos", palabrasAcertadas.size());
            editor.apply();

            parar = true;
            startActivity(new Intent(PantallaRespuesta.this, PantallaResultados.class));
        }
    }

    private void gestionarTiempo() {
        ExecutorService executor = Executors.newSingleThreadExecutor();
        Handler handler = new Handler(Looper.getMainLooper());

        executor.execute(new Runnable() {
            @Override
            public void run() {
                try {
                    for (int i = 20; i > 0; i--) {
                        int number = i;
                        handler.post(new Runnable() {
                            @Override
                            public void run() {
                                binding.txtContador.setText(number + "");
                            }
                        });
                        Thread.sleep(1000);
                    }
                }
                catch (InterruptedException e) {
                    throw new RuntimeException(e);
                }

                handler.post(new Runnable() {
                    @Override
                    public void run() {
                        if (!parar) {
                            SharedPreferences.Editor editor = numeroAciertosPreferences.edit();
                            editor.putInt("numeroAciertos", palabrasAcertadas.size());
                            editor.apply();

                            startActivity(new Intent(PantallaRespuesta.this, PantallaResultados.class));
                        }
                    }
                });
            }
        });
    }
}