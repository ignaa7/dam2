package com.example.pruebaexamen.pantallasPuntuaciones;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import com.example.pruebaexamen.MainActivity;
import com.example.pruebaexamen.R;

public class PantallaPuntuaciones extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pantalla_puntuaciones);

        SharedPreferences maxNumeroAciertosPreferences = getSharedPreferences("maximoNumeroAciertos", Context.MODE_PRIVATE);

        int maxNumAciertos = maxNumeroAciertosPreferences.getInt("maximoNumeroAciertos", 0);

        TextView txtPuntuacion = findViewById(R.id.txtPuntuacion);

        txtPuntuacion.setText("Su puntuación más alta es de " + maxNumAciertos + " aciertos");
    }

    public void volverInicio(View view) {
        Intent intent = new Intent(this, MainActivity.class);
        intent.setFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP | Intent.FLAG_ACTIVITY_SINGLE_TOP);
        startActivity(intent);
        finish();
    }
}