package com.example.juegoandroid.models;

import android.graphics.Bitmap;
import android.graphics.Canvas;

import com.example.juegoandroid.surfaceViews.GameSurfaceView;

public class Grill {
    private float x;
    private float y;
    private Bitmap bitmap;
    GameSurfaceView gameSurfaceView;

    public Grill(int i, GameSurfaceView gameSurfaceView, Bitmap bitmap) {
        this.bitmap = bitmap;
        this.gameSurfaceView = gameSurfaceView;

        int viewWidth = gameSurfaceView.getWidth();
        int viewHeight = gameSurfaceView.getHeight();

        int bitmapScaledWidth = gameSurfaceView.getWidth() / 4;
        int bitmapScaledHeight = gameSurfaceView.getHeight()  / 3;
        this.bitmap = Bitmap.createScaledBitmap(bitmap, bitmapScaledWidth, bitmapScaledHeight, true);

        int bitmapWidth = this.bitmap.getWidth();
        int bitmapHeight = this.bitmap.getHeight();

        switch (i) {
            case 0:
                x = viewWidth * 0.05f;
                y = viewHeight * 0.2f;
                break;
            case 1:
                x = viewWidth * 0.05f + bitmapWidth;
                y = viewHeight * 0.2f;
                break;
            case 2:
                x = viewWidth * 0.05f;
                y = viewHeight * 0.3f + bitmapHeight;
                break;
            case 3:
                x = viewWidth * 0.05f + bitmapWidth;
                y = viewHeight * 0.3f + bitmapHeight;
                break;
            default:
                break;
        }
    }

    public void onDraw(Canvas canvas) {
        canvas.drawBitmap(bitmap, x, y, null);
    }
}
