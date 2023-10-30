package com.example.a2_pizzeria;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;

import com.example.a2_pizzeria.databinding.ActivityMainScreenBinding;
import com.example.a2_pizzeria.databinding.ActivitySettingsScreenBinding;

public class SettingsScreen extends AppCompatActivity {

    private ActivitySettingsScreenBinding binding;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_settings_screen);
        binding = ActivitySettingsScreenBinding.inflate(getLayoutInflater());
        View view = binding.getRoot();
        setContentView(view);
    }
}