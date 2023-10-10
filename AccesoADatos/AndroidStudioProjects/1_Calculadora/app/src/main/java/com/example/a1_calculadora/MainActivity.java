package com.example.a1_calculadora;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import net.objecthunter.exp4j.Expression;
import net.objecthunter.exp4j.ExpressionBuilder;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    TextView txtPantalla;
    Button btnAC;
    Button btnDEL;
    Button btn9;
    Button btn8;
    Button btn7;
    Button btn6;
    Button btn5;
    Button btn4;
    Button btn3;
    Button btn2;
    Button btn1;
    Button btn0;
    Button btnPunto;
    Button btnSuma;
    Button btnResta;
    Button btnMultiplicacion;
    Button btnDivision;
    Button btnIgual;

    String cadena = "0";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        txtPantalla = findViewById(R.id.txtPantalla);
        btnAC = findViewById(R.id.btnAC);
        btnDEL = findViewById(R.id.btnDEL);
        btn9 = findViewById(R.id.btn9);
        btn8 = findViewById(R.id.btn8);
        btn7 = findViewById(R.id.btn7);
        btn6 = findViewById(R.id.btn6);
        btn5 = findViewById(R.id.btn5);
        btn4 = findViewById(R.id.btn4);
        btn3 = findViewById(R.id.btn3);
        btn2 = findViewById(R.id.btn2);
        btn1 = findViewById(R.id.btn1);
        btn0 = findViewById(R.id.btn0);
        btnPunto = findViewById(R.id.btnPunto);
        btnSuma = findViewById(R.id.btnSuma);
        btnResta = findViewById(R.id.btnResta);
        btnMultiplicacion = findViewById(R.id.btnMultiplicacion);
        btnDivision = findViewById(R.id.btnDivision);
        btnIgual = findViewById(R.id.btnIgual);

        txtPantalla.setOnClickListener(this);
        btnAC.setOnClickListener(this);
        btnDEL.setOnClickListener(this);
        btn9.setOnClickListener(this);
        btn8.setOnClickListener(this);
        btn7.setOnClickListener(this);
        btn6.setOnClickListener(this);
        btn5.setOnClickListener(this);
        btn4.setOnClickListener(this);
        btn3.setOnClickListener(this);
        btn2.setOnClickListener(this);
        btn1.setOnClickListener(this);
        btn0.setOnClickListener(this);
        btnPunto.setOnClickListener(this);
        btnSuma.setOnClickListener(this);
        btnResta.setOnClickListener(this);
        btnMultiplicacion.setOnClickListener(this);
        btnDivision.setOnClickListener(this);
        btnIgual.setOnClickListener(this);
    }

    @Override
    public void onClick(View view) {
        String txtBtn = ((Button)view).getText().toString();

        if (txtBtn.equals("=")) {
            try {
                ExpressionBuilder expressionBuilder = new ExpressionBuilder(cadena);
                Expression expression = expressionBuilder.build();
                double resultado = expression.evaluate();
                txtPantalla.setText(resultado + "");
                cadena = "0";
            }
            catch (Exception exception) {
                txtPantalla.setText("ERROR");
                cadena = "0";
            }
        }
        else if (txtBtn.equals("AC")) {
            cadena = "0";
            txtPantalla.setText(cadena);
        }
        else if (txtBtn.equals("DEL")) {
            if (cadena.length() > 1) {
                cadena = cadena.substring(0, cadena.length() - 1);
            }
            else {
                cadena = "0";
            }
            txtPantalla.setText(cadena);
        }
        else if (txtBtn.equals("x")) {
            cadena += "*";
            txtPantalla.setText(cadena);
        }
        else if (txtBtn.equals("÷")) {
            cadena += "/";
            txtPantalla.setText(cadena);
        }
        else {
            cadena += txtBtn;
            txtPantalla.setText(cadena);
        }
    }
}