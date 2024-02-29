package com.example.juegoandroid;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.media.MediaPlayer;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;


public class MenuScreen extends AppCompatActivity {
    private MediaPlayer music;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
                WindowManager.LayoutParams.FLAG_FULLSCREEN);

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu_screen);

        music = MediaPlayer.create(this, R.raw.menu);
    }

    @Override
    protected void onResume() {
        super.onResume();
        if (!music.isPlaying()) {
            music = MediaPlayer.create(this, R.raw.menu);
            music.start();
            music.setLooping(true);
        }
    }

    public void goToGameScreen(View view) {
        music.stop();
        startActivity(new Intent(this, GameScreen.class));
    }

    public void goToScoreScreen(View view) {
        startActivity(new Intent(this, ScoreScreen.class));
    }

    public void goToStoreScreen(View view) {
        startActivity(new Intent(this, StoreScreen.class));
    }

    public void goToSettingsScreen(View view) {
        startActivity(new Intent(this, SettingsScreen.class));
    }

    public void exit(View view) {
        AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(this);

        alertDialogBuilder.setTitle("Salir");
        alertDialogBuilder.setMessage("¿Desea salir?");

        alertDialogBuilder.setPositiveButton("Salir", (dialog, which) -> {
            music.stop();
            finishAffinity();
        });

        alertDialogBuilder.setNegativeButton("Cancelar", (dialog, which) -> {

        });

        AlertDialog alertDialog = alertDialogBuilder.create();
        alertDialog.show();
    }
}