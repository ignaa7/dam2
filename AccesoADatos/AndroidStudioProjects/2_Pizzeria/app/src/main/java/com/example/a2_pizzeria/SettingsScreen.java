package com.example.a2_pizzeria;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;

import com.example.a2_pizzeria.databinding.ActivityMainScreenBinding;
import com.example.a2_pizzeria.databinding.ActivitySettingsScreenBinding;

import yuku.ambilwarna.AmbilWarnaDialog;

public class SettingsScreen extends AppCompatActivity {

    private SharedPreferences screensColorPreferences;
    private ActivitySettingsScreenBinding binding;

    int color;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_settings_screen);
        binding = ActivitySettingsScreenBinding.inflate(getLayoutInflater());
        View view = binding.getRoot();
        setContentView(view);

        screensColorPreferences = getSharedPreferences("screensColor", Context.MODE_PRIVATE);
        color = screensColorPreferences.getInt("color", 0);
        binding.getRoot().setBackgroundColor(color);
    }

    public void changeBackgroundColor() {
        AmbilWarnaDialog colorDialog = new AmbilWarnaDialog(this, color, new AmbilWarnaDialog.OnAmbilWarnaListener() {
            @Override
            public void onCancel(AmbilWarnaDialog dialog) {

            }

            @Override
            public void onOk(AmbilWarnaDialog dialog, int color) {

            }
        })
    }
}