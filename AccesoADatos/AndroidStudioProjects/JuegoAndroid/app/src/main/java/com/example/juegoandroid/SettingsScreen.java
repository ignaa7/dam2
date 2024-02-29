package com.example.juegoandroid;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.RadioButton;

import com.example.juegoandroid.databinding.ActivityScoreScreenBinding;
import com.example.juegoandroid.databinding.ActivitySettingsScreenBinding;

public class SettingsScreen extends AppCompatActivity {
    private ActivitySettingsScreenBinding binding;
    private SharedPreferences difficultyPreferences;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
                WindowManager.LayoutParams.FLAG_FULLSCREEN);

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_settings_screen);

        binding = ActivitySettingsScreenBinding.inflate(getLayoutInflater());
        View view = binding.getRoot();
        setContentView(view);

        difficultyPreferences = getSharedPreferences("difficulty", Context.MODE_PRIVATE);
        String difficulty = difficultyPreferences.getString("difficulty", "easy");

        if (difficulty.equals("easy")) {
            binding.rbEasy.setChecked(true);
        } else if (difficulty.equals("medium")) {
            binding.rbMedium.setChecked(true);
        } else if (difficulty.equals("hard")) {
            binding.rbHard.setChecked(true);
        }
    }

    public void goBack(View view) {
        int idSelectedDifficulty = binding.rgDifficulty.getCheckedRadioButtonId();
        String difficultyText = ((RadioButton)findViewById(idSelectedDifficulty)).getText().toString();
        String difficulty = "";

        if (difficultyText.equals("Fácil (hamburguesas quemadas en 5s)")) {
            difficulty = "easy";
        } else if (difficultyText.equals("Media (hamburguesas quemadas en 3s)")) {
            difficulty = "medium";
        } else if (difficultyText.equals("Difícil (hamburguesas quemadas en 1s)")) {
            difficulty = "hard";
        }

        SharedPreferences.Editor editor = difficultyPreferences.edit();
        editor.putString("difficulty", difficulty);
        editor.apply();

        finish();
    }
}