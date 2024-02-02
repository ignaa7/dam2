package com.example.pruebamoversprites;

import android.graphics.Bitmap;
import android.graphics.Canvas;

import java.util.ArrayList;
import java.util.List;

public class Sangre {
    private float x;
    private float y;
    private Bitmap bitmap;
    private List<Sangre> sangres = new ArrayList<Sangre>();
    private int life = 15;

    public Sangre(float x, float y, Bitmap bitmap, MoverSprites moverSprites, List<Sangre> sangres) {
        this.x = Math.min(Math.max(x - bitmap.getWidth() / 2, 0), moverSprites.getWidth() - bitmap.getWidth());
        this.y = Math.min(Math.max(y - bitmap.getHeight() / 2, 0), moverSprites.getHeight() - bitmap.getHeight());
        this.bitmap = bitmap;
        this.sangres = sangres;
    }

    public void onDraw(Canvas canvas) {
        update();
        canvas.drawBitmap(bitmap, x, y, null);
    }

    private void update() {
        if (--life < 1) {
            sangres.remove(this);
        }
    }
}
