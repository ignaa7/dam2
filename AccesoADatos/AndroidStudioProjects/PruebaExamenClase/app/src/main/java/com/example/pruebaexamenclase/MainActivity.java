package com.example.pruebaexamenclase;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.TextView;

import com.example.pruebaexamenclase.dao.DbHelper;

import java.util.List;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        DbHelper dbHelper = new DbHelper(this);
        List<String> nombres = dbHelper.getNombres();
        TextView txtCuadro = findViewById(R.id.txtCuadro);

        txtCuadro.setText("prueba");

        for (String nombre : nombres) {
            txtCuadro.setText(txtCuadro.getText() + nombre);
        }
    }
}