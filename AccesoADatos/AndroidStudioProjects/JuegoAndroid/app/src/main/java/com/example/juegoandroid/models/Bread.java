package com.example.juegoandroid.models;

import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.graphics.Rect;

import com.example.juegoandroid.surfaceViews.GameSurfaceView;

public class Bread {
    private static final int BITMAP_ROWS = 2;
    private static final int BITMAP_COLUMNS = 2;
    private  int width;
    private int height;
    Rect src;
    Rect dst;
    private GameSurfaceView gameSurfaceView;
    private Bitmap bitmap;

    public Bread(GameSurfaceView gameSurfaceView, Bitmap bitmap) {
        this.gameSurfaceView = gameSurfaceView;
        this.bitmap = bitmap;

        int viewWidth = this.gameSurfaceView.getWidth();
        int viewHeight = this.gameSurfaceView.getHeight();

        int bitmapScaledWidth = viewWidth / 6;
        int bitmapScaledHeight = viewHeight  / 3;
        this.bitmap = Bitmap.createScaledBitmap(bitmap, bitmapScaledWidth, bitmapScaledHeight, true);

        this.width = this.bitmap.getWidth() / BITMAP_COLUMNS;
        this.height = this.bitmap.getHeight() / BITMAP_ROWS;
        src = new Rect(0, height, width, height * 2);

        int x = (int) (viewWidth * 0.733);
        int y = (int) (viewHeight * 0.573);
        dst = new Rect(x, y, x + width, y + height);
    }

    public void onDraw(Canvas canvas) {
        canvas.drawBitmap(bitmap, src, dst, null);
    }
}
