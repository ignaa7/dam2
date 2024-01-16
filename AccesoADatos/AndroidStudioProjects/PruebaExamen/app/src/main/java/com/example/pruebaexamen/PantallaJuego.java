package com.example.pruebaexamen;

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
import android.widget.TextView;
import android.widget.Toast;

import com.example.pruebaexamen.dbHelper.DbHelper;

import java.util.HashSet;
import java.util.List;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class PantallaJuego extends AppCompatActivity {

    private DbHelper dbHelper = new DbHelper(this);
    private List<String> palabras;
    private ListView lstPalabras;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pantalla_juego);

        palabras = dbHelper.getPalabras();

        SharedPreferences palabrasPreferences = getSharedPreferences("palabras", Context.MODE_PRIVATE);

        if (palabrasPreferences.getAll().isEmpty()) {
            SharedPreferences.Editor editor = palabrasPreferences.edit();
            editor.putStringSet("palabras", new HashSet<>(palabras));
            editor.apply();
        }

        lstPalabras = findViewById(R.id.lstPalabras);

        ArrayAdapter<String> adapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, palabras);
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

    private void mostrarPalabras() {
        ExecutorService executor = Executors.newSingleThreadExecutor();
        Handler handler = new Handler(Looper.getMainLooper());

        executor.execute(new Runnable() {
            @Override
            public void run() {
                try {
                    for (String palabra: palabras) {
                        handler.post(new Runnable() {
                            @Override
                            public void run() {
                                Toast.makeText(PantallaJuego.this, palabra, Toast.LENGTH_SHORT).show();
                            }
                        });

                        Thread.sleep(2000);
                    }
                }
                catch (InterruptedException e) {
                    throw new RuntimeException(e);
                }

                handler.post(new Runnable() {
                    @Override
                    public void run() {
                        startActivity(new Intent(PantallaJuego.this, PantallaRespuesta.class));
                    }
                });
            }
        });
    }
}