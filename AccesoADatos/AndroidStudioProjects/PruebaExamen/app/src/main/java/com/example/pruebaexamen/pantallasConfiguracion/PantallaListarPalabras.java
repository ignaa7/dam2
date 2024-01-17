package com.example.pruebaexamen.pantallasConfiguracion;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import com.example.pruebaexamen.MainActivity;
import com.example.pruebaexamen.R;
import com.example.pruebaexamen.dbHelper.DbHelper;

import java.util.List;

public class PantallaListarPalabras extends AppCompatActivity {
    private DbHelper dbHelper = new DbHelper(this);
    private List<String> palabras;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pantalla_listar_palabras);

        palabras = dbHelper.getPalabras();

        ArrayAdapter<String> adapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, palabras);
        ((ListView)findViewById(R.id.lstPalabras)).setAdapter(adapter);
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