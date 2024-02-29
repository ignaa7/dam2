package com.example.juegoandroid.models;

import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.graphics.Color;

import com.example.juegoandroid.surfaceViews.GameSurfaceView;

public class BreadBox {
    private float x;
    private float y;
    private Bitmap bitmap;
    GameSurfaceView gameSurfaceView;

    public BreadBox(GameSurfaceView gameSurfaceView, Bitmap bitmap) {
        this.bitmap = bitmap;
        this.gameSurfaceView = gameSurfaceView;

        int viewWidth = gameSurfaceView.getWidth();
        int viewHeight = gameSurfaceView.getHeight();

        int bitmapScaledWidth = gameSurfaceView.getWidth() / 4;
        int bitmapScaledHeight = gameSurfaceView.getHeight()  / 2;
        this.bitmap = Bitmap.createScaledBitmap(bitmap, bitmapScaledWidth, bitmapScaledHeight, true);

        x = viewWidth * 0.75f;
        y = viewHeight * 0.05f;
    }

    public void onDraw(Canvas canvas) {
        canvas.drawBitmap(bitmap, x, y, null);
    }

    public boolean isTouched(float touchedX, float touchedY) {
        if (touchedX >= x && touchedX <= x + bitmap.getWidth()
                && touchedY >= y && touchedY <= y + bitmap.getHeight()) {

            int localX = (int) (touchedX - x);
            int localY = (int) (touchedY - y);

            int pixel = bitmap.getPixel(localX, localY);
            return pixel != Color.TRANSPARENT;

        } else {
            return false;
        }
    }
}
