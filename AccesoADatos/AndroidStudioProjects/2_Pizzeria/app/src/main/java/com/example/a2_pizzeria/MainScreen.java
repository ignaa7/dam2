package com.example.a2_pizzeria;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.net.Uri;
import android.os.Bundle;
import android.text.method.LinkMovementMethod;
import android.view.View;

import com.example.a2_pizzeria.databinding.ActivityMainBinding;
import com.example.a2_pizzeria.databinding.ActivityMainScreenBinding;

public class MainScreen extends AppCompatActivity {

    private SharedPreferences currentUserPreferences;
    private SharedPreferences screensColorPreferences;
    private ActivityMainScreenBinding binding;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main_screen);
        binding = ActivityMainScreenBinding.inflate(getLayoutInflater());
        View view = binding.getRoot();
        setContentView(view);
        binding.txtLogOut.setVisibility(View.INVISIBLE);

        currentUserPreferences = getSharedPreferences("currentUser", Context.MODE_PRIVATE);
        String username = currentUserPreferences.getString("username", null);
        binding.txtUsername.setText(username);

        screensColorPreferences = getSharedPreferences("screensColor", Context.MODE_PRIVATE);
        int color = screensColorPreferences.getInt("color", 0);
        binding.getRoot().setBackgroundColor(color);
    }

    public void visitWebsite(View view) {
        String url = "http://mammamiapizzeria.es";
        startActivity(new Intent(Intent.ACTION_VIEW, Uri.parse(url)));
    }

    public void toggleLogOut (View view) {
        if (binding.txtLogOut.getVisibility() == View.VISIBLE) {
            binding.txtLogOut.setVisibility(View.INVISIBLE);
        }
        else {
            binding.txtLogOut.setVisibility(View.VISIBLE);
        }
    }

    public void logOut(View view) {
        finish();
    }
}