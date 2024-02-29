package com.example.juegoandroid.models;

import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.graphics.Rect;

import com.example.juegoandroid.surfaceViews.GameSurfaceView;

public class Coin {
    private static final int BITMAP_COLUMNS = 6;
    private int x;
    private int y;
    private int width;
    private int height;
    private Bitmap bitmap;
    GameSurfaceView gameSurfaceView;
    private Rect dst;
    private Rect src;

    public Coin(GameSurfaceView gameSurfaceView, Bitmap bitmap) {
        this.bitmap = bitmap;
        this.gameSurfaceView = gameSurfaceView;

        int viewWidth = gameSurfaceView.getWidth();
        int viewHeight = gameSurfaceView.getHeight();

        int bitmapScaledWidth = viewWidth / 4;
        int bitmapScaledHeight = viewHeight  / 7;
        this.bitmap = Bitmap.createScaledBitmap(bitmap, bitmapScaledWidth, bitmapScaledHeight, true);

        width = this.bitmap.getWidth() / BITMAP_COLUMNS;
        height = this.bitmap.getHeight();

        x = (int) (viewWidth * 0.85f);
        y = (int) (viewHeight * 0.02f);

        dst = new Rect(x, y, x + width, y + height);
    }

    public int getWidth() {
        return width;
    }

    public void onDraw(Canvas canvas) {
        src = new Rect(0, 0, width, height);
        canvas.drawBitmap(bitmap, src, dst, null);
    }
}
