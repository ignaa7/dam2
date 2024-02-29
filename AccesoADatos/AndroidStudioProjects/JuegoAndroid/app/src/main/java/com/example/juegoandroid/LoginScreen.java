package com.example.juegoandroid;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.Toast;

import com.example.juegoandroid.dao.DbHelper;
import com.example.juegoandroid.databinding.ActivityLoginScreenBinding;
import com.example.juegoandroid.databinding.ActivityScoreScreenBinding;

public class LoginScreen extends AppCompatActivity {
    private ActivityLoginScreenBinding binding;
    private DbHelper dbHelper;
    private SharedPreferences currentUserPreferences;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
                WindowManager.LayoutParams.FLAG_FULLSCREEN);

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login_screen);

        binding = ActivityLoginScreenBinding.inflate(getLayoutInflater());
        View view = binding.getRoot();
        setContentView(view);

        dbHelper = new DbHelper(this);

        currentUserPreferences = getSharedPreferences("currentUser", Context.MODE_PRIVATE);
    }

    public void logIn(View view) {
        String username = binding.edtUsername.getText().toString();
        if (username.isEmpty()) {
            Toast.makeText(this, "Introduzca un nombre de usuario", Toast.LENGTH_SHORT).show();
        } else {
            if (dbHelper.checkUser(username)) {
                Toast.makeText(this, "Sesión iniciada correctamente", Toast.LENGTH_SHORT).show();
            } else {
                Toast.makeText(this, "Usuario registrado correctamente", Toast.LENGTH_SHORT).show();
            }
            SharedPreferences.Editor editor = currentUserPreferences.edit();
            editor.putString("username", username);
            editor.apply();

            finish();
        }
    }

    public void goBack(View view) {
        finish();
    }
}