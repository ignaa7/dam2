package com.example.juegoandroid;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.graphics.Color;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;

import com.example.juegoandroid.dao.DbHelper;
import com.example.juegoandroid.databinding.ActivityScoreScreenBinding;
import com.example.juegoandroid.models.User;

import java.util.ArrayList;
import java.util.List;

public class ScoreScreen extends AppCompatActivity {
    private ActivityScoreScreenBinding binding;
    private DbHelper dbHelper;
    private SharedPreferences currentUserPreferences;
    private boolean isLoggedIn = false;
    private List<User> users;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
                WindowManager.LayoutParams.FLAG_FULLSCREEN);

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_score_screen);

        binding = ActivityScoreScreenBinding.inflate(getLayoutInflater());
        View view = binding.getRoot();
        setContentView(view);

        dbHelper = new DbHelper(this);

        users = dbHelper.getUsers();

        User bestUser = null;
        if (users.size() > 0) {
            bestUser = users.get(0);
        }
        for (User user : users) {
            if (user.getScore() > bestUser.getScore()) {
                bestUser = user;
            }
        }

        if (bestUser != null) {
            binding.txtBestScore.setText(bestUser.getUsername() + " : " + bestUser.getScore());
        } else {
            binding.txtBestScore.setText("Ninguna puntuación registrada");
        }
    }

    public void goToLoginScreen(View view) {
        if (!isLoggedIn) {
            startActivity(new Intent(this, LoginScreen.class));
        } else {
            currentUserPreferences.edit().remove("username");
            binding.txtYourBestScore.setText("Inicie sesión para ver su puntuación");
            binding.btnSignIn.setText("Iniciar sesión");
            binding.btnSignIn.setBackgroundColor(Color.parseColor("#2196F3"));
            isLoggedIn = false;
        }
    }

    @Override
    protected void onResume() {
        super.onResume();
        currentUserPreferences = getSharedPreferences("currentUser", Context.MODE_PRIVATE);
        String username = currentUserPreferences.getString("username", "");

//        dbHelper.setCoins(username, 1000);

        if (!username.equals("")) {
            User currentUser = users.stream().filter(user -> user.getUsername().equals(username)).findFirst().orElse(null);
            if (currentUser != null) {
                binding.txtYourBestScore.setText(currentUser.getUsername() + " : " + currentUser.getScore());
                binding.btnSignIn.setText("Cerrar sesión");
                binding.btnSignIn.setBackgroundColor(Color.RED);
                isLoggedIn = true;
            } else {
                binding.txtYourBestScore.setText("Inicie sesión para ver su puntuación");
                binding.btnSignIn.setText("Iniciar sesión");
                binding.btnSignIn.setBackgroundColor(Color.parseColor("#2196F3"));
                isLoggedIn = false;
            }
        } else {
            binding.txtYourBestScore.setText("Inicie sesión para ver su puntuación");
            binding.btnSignIn.setText("Iniciar sesión");
            binding.btnSignIn.setBackgroundColor(Color.parseColor("#2196F3"));
            isLoggedIn = false;
        }
    }

    public void goBack(View view) {
        finish();
    }
}