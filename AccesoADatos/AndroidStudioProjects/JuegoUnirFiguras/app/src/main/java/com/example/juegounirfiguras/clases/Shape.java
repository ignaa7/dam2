package com.example.juegounirfiguras.clases;

import android.graphics.Canvas;
import android.graphics.Paint;

public abstract class Shape {
    protected float x;
    protected float y;
    protected Float initialX;
    protected Float initialY;
    protected boolean filled;

    public Shape(float x, float y, boolean filled) {
        this.x = x;
        this.y = y;
        this.filled = filled;
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

    public Float getInitialX() {
        return initialX;
    }

    public void setInitialX(Float initialX) {
        this.initialX = initialX;
    }

    public Float getInitialY() {
        return initialY;
    }

    public void setInitialY(Float initialY) {
        this.initialY = initialY;
    }

    public void mover(float xActual, float yActual) {
        if (initialX != null && initialY != null) {
            setX(getX() + xActual - initialX);
            setY(getY() + yActual - initialY);
            initialX = xActual;
            initialY = yActual;
        }
    }

    public abstract boolean isHovered(float x, float y);

    public abstract void onDraw(Canvas canvas, Paint paint);

    public boolean isNear(float x, float y) {
        return Math.abs(x - this.x) < 10 && Math.abs(y - this.y) < 10;
    }
}
