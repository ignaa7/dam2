package com.example.pruebamoversprites;

import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.graphics.Rect;

import java.util.Random;

public class Sprite {
    private static final int[] DIRECTION_TO_ANIMATION_MAP = {3, 1, 0, 2};
    private static final int BITMAP_FILAS = 4;
    private static final int BITMAP_COLUMNAS = 3;
    private static final int MAX_SPEED = 20;
    private int x = 0;
    private int y = 0;
    private int xSpeed = 5;
    private MoverSprites moverSprites;
    private Bitmap bitmap;
    private int currentFrame = 0;
    private  int width;
    private int height;
    private  int ySpeed;

    public Sprite(MoverSprites moverSprites, Bitmap bitmap) {
        this.moverSprites = moverSprites;
        this.bitmap = bitmap;
        this.width = bitmap.getWidth() / BITMAP_COLUMNAS;
        this.height = bitmap.getHeight() / BITMAP_FILAS;

        Random rnd = new Random();
        x = rnd.nextInt(moverSprites.getWidth() - width);
        y = rnd.nextInt(moverSprites.getHeight() - height);
        xSpeed = rnd.nextInt(MAX_SPEED * 2) - MAX_SPEED;
        ySpeed = rnd.nextInt(MAX_SPEED * 2) - MAX_SPEED;
    }

    private void update() {
        if (x > moverSprites.getWidth() - width - xSpeed || x + xSpeed < 0) {
            xSpeed = -xSpeed;
        }
        x = x + xSpeed;
        if (y > moverSprites.getHeight() - height - ySpeed || y + ySpeed < 0) {
            ySpeed = -ySpeed;
        }
        y = y + ySpeed;
        currentFrame = ++currentFrame % BITMAP_COLUMNAS;
    }

    public void onDraw(Canvas canvas) {
        update();
        int srcX = currentFrame * width;
        int srcY = getAnimationRow() * height;
        Rect src = new Rect(srcX, srcY, srcX + width, srcY + height);
        Rect dst = new Rect(x, y, x + width, y + height);
        canvas.drawBitmap(bitmap, src, dst, null);
    }

    private int getAnimationRow() {
        double dirDouble = (Math.atan2(xSpeed, ySpeed) / (Math.PI / 2) + 2);
        int direction = (int) Math.round(dirDouble) % BITMAP_FILAS;
        return DIRECTION_TO_ANIMATION_MAP[direction];
    }

    public boolean isCollition(float x2, float y2) {
        return x2 > x && x2 < x + width && y2 > y && y2 < y + height;
    }
}
