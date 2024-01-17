package com.example.pruebaexamen.pantallasJuego;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.os.Handler;
import android.os.Looper;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.ProgressBar;
import android.widget.Toast;

import com.example.pruebaexamen.MainActivity;
import com.example.pruebaexamen.R;
import com.example.pruebaexamen.dbHelper.DbHelper;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class PantallaJuego extends AppCompatActivity {

    private DbHelper dbHelper = new DbHelper(this);
    private List<String> palabras;
    private ListView lstPalabras;
    private ProgressBar pbTiempo;
    private boolean parar = false;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pantalla_juego);

        // database query
        palabras = dbHelper.getPalabras();

        // SharedPreferences insert values
        SharedPreferences palabrasPreferences = getSharedPreferences("palabras", Context.MODE_PRIVATE);

        if (palabrasPreferences.getAll().isEmpty()) {
            SharedPreferences.Editor editor = palabrasPreferences.edit();
            editor.putStringSet("palabras", new HashSet<>(palabras));
            editor.apply();
        }

        lstPalabras = findViewById(R.id.lstPalabras);
        pbTiempo = findViewById(R.id.pbTiempo);

        // show 1/2/3 words depending on difficulty
        List<String> palabrasFiltradas = new ArrayList<>();
        SharedPreferences dificultadPreferences = getSharedPreferences("dificultad", Context.MODE_PRIVATE);
        String dificultad = dificultadPreferences.getString("dificultad", "dificil");

        if (dificultad.equals("dificil")) {
            palabrasFiltradas = palabras;
        } else if (dificultad.equals("medio")) {
            palabrasFiltradas = palabras.subList(0, 2);
        } else if (dificultad.equals("facil")) {
            palabrasFiltradas = palabras.subList(0, 1);
        }

        ArrayAdapter<String> adapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, palabrasFiltradas);
        lstPalabras.setAdapter(adapter);

        lstPalabras.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                String selectedItem = (String) parent.getItemAtPosition(position);
                Toast.makeText(PantallaJuego.this, "Selected: " + selectedItem, Toast.LENGTH_SHORT).show();
            }
        });

        mostrarPalabras();
    }

    public void volverInicio(View view) {
        Intent intent = new Intent(this, MainActivity.class);
        intent.setFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP | Intent.FLAG_ACTIVITY_SINGLE_TOP);
        parar = true;
        startActivity(intent);
        finish();
    }

    private void mostrarPalabras() {
        ExecutorService executor = Executors.newSingleThreadExecutor();
        Handler handler = new Handler(Looper.getMainLooper());

        executor.execute(new Runnable() {
            @Override
            public void run() {
                try {
                    for (int i = 0; i < 5; i++) {
                        int number = i;
                        handler.post(new Runnable() {
                            @Override
                            public void run() {
                                pbTiempo.setProgress(number * 20);
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
                            startActivity(new Intent(PantallaJuego.this, PantallaRespuesta.class));
                        }
                    }
                });
            }
        });
    }
}