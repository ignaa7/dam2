package com.example.ejercicio1;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    private TextView txtNumero;
    private int idBtnMas;
    private int idBtnMenos;
    private int idBtnReset;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        this.idBtnMas = findViewById(R.id.btnMas).getId();
        this.idBtnMenos = findViewById(R.id.btnMenos).getId();
        this.idBtnReset = findViewById(R.id.btnReset).getId();
        this.txtNumero = findViewById(R.id.txtNumero);
        this.txtNumero.setText("0");

        findViewById(R.id.btnMas).setOnClickListener(this);
        findViewById(R.id.btnMenos).setOnClickListener(this);
        findViewById(R.id.btnReset).setOnClickListener(this);
    }

    @Override
    public void onClick(View view) {
        int viewId = view.getId();
        int numero = Integer.parseInt(txtNumero.getText().toString());

        if (viewId == idBtnMas) txtNumero.setText(numero + 1 + "");
        else if (viewId == idBtnMenos && numero > 0) txtNumero.setText(numero - 1 + "");
        else if (viewId == idBtnReset) txtNumero.setText("0");
    }
}