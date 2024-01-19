package com.example.pruebamoverfiguras;

import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.graphics.Path;

public class Linea extends Figura {
    public Linea(float x, float y) {
        super(x, y);
    }

    @Override
    public boolean isHovered(float x, float y) {
        return false;
    }

    @Override
    public void onDraw(Canvas canvas, Paint paint) {
        canvas.drawColor(Color.WHITE);
        paint.setColor(Color.RED);

        Path path = new Path();
        //path.lineTo();
    }
}
