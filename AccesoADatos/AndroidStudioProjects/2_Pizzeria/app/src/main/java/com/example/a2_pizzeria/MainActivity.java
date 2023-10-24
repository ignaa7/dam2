package com.example.a2_pizzeria;

import androidx.appcompat.app.AppCompatActivity;

import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;

import com.example.a2_pizzeria.databinding.ActivityMainBinding;

public class MainActivity extends AppCompatActivity {

    SharedPreferences preferences = getSharedPreferences("users", MODE_PRIVATE); //error
    ActivityMainBinding binding;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        binding = ActivityMainBinding.inflate(getLayoutInflater());
        View view = binding.getRoot();
        setContentView(view);
    }

    public void signUpUser() {
        SharedPreferences.Editor editor = preferences.edit();
        editor.putString(binding.edtName.getText().toString(), binding.edtPassword.getText().toString());
    }
}