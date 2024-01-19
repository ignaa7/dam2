package com.example.pruebamoverfiguras;

import android.graphics.Canvas;
import android.graphics.Paint;

public abstract class Figura {
    protected float x;
    protected float y;
    protected float xInicial;
    protected float yInicial;

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

    public float getxInicial() {
        return xInicial;
    }

    public void setxInicial(float xInicial) {
        this.xInicial = xInicial;
    }

    public float getyInicial() {
        return yInicial;
    }

    public void setyInicial(float yInicial) {
        this.yInicial = yInicial;
    }

    public void mover(float xActual, float yActual) {
        setX(getX() + xActual - xInicial);
        setY(getY() + yActual - yInicial);
        xInicial = xActual;
        yInicial = yActual;
    }

    public abstract boolean isHovered(float x, float y);

    public abstract void onDraw(Canvas canvas, Paint paint);
}
