package com.example.juegoandroid.models;

import android.graphics.Bitmap;

import com.example.juegoandroid.surfaceViews.GameSurfaceView;

public class Burguer {
    private static final int BITMAP_ROWS = 2;
    private static final int BITMAP_COLUMNS = 2;
    private int x = 0;
    private int y = 0;
    private  int width;
    private int height;
    private GameSurfaceView gameSurfaceView;
    private Bitmap bitmap;

    public Burguer(GameSurfaceView gameSurfaceView, Bitmap bitmap) {
        this.gameSurfaceView = gameSurfaceView;
        this.bitmap = bitmap;

        this.width = bitmap.getWidth() / BITMAP_COLUMNS;
        this.height = bitmap.getHeight() / BITMAP_ROWS;
    }
}
