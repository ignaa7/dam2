package com.example.juegoandroid.models;

import android.graphics.Bitmap;
import android.graphics.Canvas;

import com.example.juegoandroid.surfaceViews.GameSurfaceView;

public class Table {
    private float x;
    private float y;
    private Bitmap bitmap;
    GameSurfaceView gameSurfaceView;

    public Table(GameSurfaceView gameSurfaceView, Bitmap bitmap) {
        this.bitmap = bitmap;
        this.gameSurfaceView = gameSurfaceView;

        int viewWidth = gameSurfaceView.getWidth();
        int viewHeight = gameSurfaceView.getHeight();

        int bitmapScaledWidth = viewWidth / 4;
        int bitmapScaledHeight = viewHeight  / 2;
        this.bitmap = Bitmap.createScaledBitmap(bitmap, bitmapScaledWidth, bitmapScaledHeight, true);

        x = viewWidth * 0.65f;
        y = viewHeight * 0.5f;
    }

    public void onDraw(Canvas canvas) {
        canvas.drawBitmap(bitmap, x, y, null);
    }
}
