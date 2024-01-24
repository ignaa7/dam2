package com.example.juegounirfiguras.clases;

import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;

public class Circle extends Shape {
    private float radio;

    public Circle(float x, float y, float radio) {
        super(x, y);
        this.radio = radio;
    }

    public float getRadio() {
        return radio;
    }

    public void setRadio(float radio) {
        this.radio = radio;
    }

    @Override
    public boolean isHovered(float x, float y) {
        double distanciaX = x - this.x;
        double distanciaY = y - this.y;
        return Math.pow(radio, 2) >  Math.pow(distanciaX, 2) + Math.pow(distanciaY, 2);
    }

    @Override
    public void onDraw(Canvas canvas, Paint paint) {
        paint.setColor(Color.BLUE);
        canvas.drawCircle(x, y, radio, paint);
    }
}
