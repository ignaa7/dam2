package com.example.a2_pizzeria;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;

import com.example.a2_pizzeria.databinding.ActivityConfirmationScreenBinding;
import com.example.a2_pizzeria.databinding.ActivityLoadingScreenBinding;

public class LoadingScreen extends AppCompatActivity {

    private ActivityLoadingScreenBinding binding;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_loading_screen);

        binding = ActivityLoadingScreenBinding.inflate(getLayoutInflater());
        View view = binding.getRoot();
        setContentView(view);
    }
}