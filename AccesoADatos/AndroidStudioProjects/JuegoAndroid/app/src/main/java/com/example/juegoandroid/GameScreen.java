package com.example.juegoandroid;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;

import com.example.juegoandroid.surfaceViews.GameSurfaceView;

public class GameScreen extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(new GameSurfaceView(this));
    }
}