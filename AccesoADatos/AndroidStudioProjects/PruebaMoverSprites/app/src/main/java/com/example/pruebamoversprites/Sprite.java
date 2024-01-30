package com.example.pruebamoversprites;

import android.graphics.Bitmap;
import android.graphics.Canvas;

public class Sprite {
    private int x = 0;
    private int xSpeed = 5;
    private MoverSprites moverSprites;
    private Bitmap bitmap;

    public Sprite(MoverSprites moverSprites, Bitmap bitmap) {
        this.moverSprites = moverSprites;
        this.bitmap = bitmap;
    }

    private void update() {
        if (x > moverSprites.getWidth() - bitmap.getWidth() - xSpeed) {
            xSpeed = -5;
        }
        if (x + xSpeed < 0) {
            xSpeed = 5;
        }

        x = x + xSpeed;
    }

    public void onDraw(Canvas canvas) {
        update();
        canvas.drawBitmap(bitmap, x, 10, null);
    }
}