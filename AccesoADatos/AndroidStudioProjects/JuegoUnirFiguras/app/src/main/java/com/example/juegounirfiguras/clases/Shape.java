package com.example.juegounirfiguras.clases;

import android.graphics.Canvas;
import android.graphics.Paint;

public abstract class Shape {
    protected float x;
    protected float y;
    protected Float xInicial;
    protected Float yInicial;
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

    public Float getxInicial() {
        return xInicial;
    }

    public void setxInicial(Float xInicial) {
        this.xInicial = xInicial;
    }

    public Float getyInicial() {
        return yInicial;
    }

    public void setyInicial(Float yInicial) {
        this.yInicial = yInicial;
    }

    public void mover(float xActual, float yActual) {
        if (xInicial != null && yInicial != null) {
            setX(getX() + xActual - xInicial);
            setY(getY() + yActual - yInicial);
            xInicial = xActual;
            yInicial = yActual;
        }
    }

    public abstract boolean isHovered(float x, float y);

    public abstract void onDraw(Canvas canvas, Paint paint);
}