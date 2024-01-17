package com.example.pruebaultima;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.TextView;

import com.example.pruebaultima.dao.DbHelper;

import java.util.List;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        DbHelper dbHelper = new DbHelper(this);

        List<String> palabras = dbHelper.getPalabras();
    }
}