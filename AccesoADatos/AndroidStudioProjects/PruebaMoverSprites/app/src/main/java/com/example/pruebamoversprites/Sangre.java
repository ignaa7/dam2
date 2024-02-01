package com.example.pruebamoversprites;

import android.graphics.Bitmap;
import android.graphics.Canvas;

import java.util.ArrayList;
import java.util.List;

public class Sangre {
    private float x;
    private float y;
    private Bitmap bitmap;
    private List<Sprite> sprites = new ArrayList<Sprite>();
    private List<Sangre> sangres = new ArrayList<Sangre>();
    private int life = 15;

    public Sangre(float x, float y, Bitmap bitmap, List<Sangre> sangres) {
        this.x = x;
        this.y = y;
        this.bitmap = bitmap;
        this.sangres = sangres;
    }

    public void onDraw(Canvas canvas) {
        update();
        canvas.drawBitmap(bitmap, x, y, null);

        //esto no deberia ir en este onDraw, va en el de MoverSprites, y los dos arrays tambien
        for (int i = sangres.size() - 1; i >= 0; i--) {
            sangres.get(i).onDraw(canvas);
        }
    }

    private void update() {
        if (--life < 1) {
            sangres.remove(this);
        }
    }
}
