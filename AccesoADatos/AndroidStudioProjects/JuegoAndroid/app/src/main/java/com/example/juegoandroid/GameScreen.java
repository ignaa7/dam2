package com.example.juegoandroid;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;

import com.example.juegoandroid.surfaceViews.SurfaceView;

public class GameScreen extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(new SurfaceView(this));
    }
}