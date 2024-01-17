package com.example.pruebamoverfiguras;

import android.graphics.Canvas;
import android.graphics.Paint;

public abstract class Figura {
    protected float x;
    protected float y;

    public Figura(float x, float y) {
        this.x = x;
        this.y = y;
    }

    public float getX() {
        return x;
    }

    public void setX(float x) {
        this.x = x;
    }

    public float getY() {
        return y;
    }

    public void setY(float y) {
        this.y = y;
    }

    public abstract boolean isHovered(float x, float y);

    public abstract void onDraw(Canvas canvas, Paint paint);
}
