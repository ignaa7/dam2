package com.example.pruebamoverfiguras;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.graphics.Path;
import android.view.MotionEvent;
import android.view.SurfaceHolder;
import android.view.SurfaceView;

import androidx.annotation.NonNull;

public class MoverFiguras extends SurfaceView implements SurfaceHolder.Callback {
    private GameThread gameThread;
    private Rectangulo rectangulo;
    private Circulo circulo;
    private Linea linea;
    private Paint paint;
    private Paint linePaint;


    public MoverFiguras(Context context) {
        super(context);
        rectangulo = new Rectangulo(200, 400, 700, 500);
        circulo = new Circulo(100, 100, 100);
        linea = new Linea();
        paint = new Paint();
        linePaint = new Paint();
        setBackgroundColor(Color.BLACK);
    }

    @Override
    protected void onDraw(Canvas canvas) {
        super.onDraw(canvas);
        canvas.drawColor(Color.WHITE);
        rectangulo.onDraw(canvas, paint);
        circulo.onDraw(canvas, paint);
        linea.onDraw(canvas, linePaint);
        invalidate();
    }

    @Override
    public boolean onTouchEvent(MotionEvent event) {
        //return super.onTouchEvent(event);
        switch (event.getAction()) {
            case MotionEvent.ACTION_DOWN:
                if (rectangulo.isHovered(event.getX(), event.getY())) {
                    rectangulo.setxInicial(event.getX());
                    rectangulo.setyInicial(event.getY());
                }

                if (circulo.isHovered(event.getX(), event.getY())) {
                    circulo.setxInicial(event.getX());
                    circulo.setyInicial(event.getY());
                }

                linea.guardarPuntoInicial(event.getX(), event.getY());
                break;
            case MotionEvent.ACTION_MOVE:
                rectangulo.mover(event.getX(), event.getY());
                circulo.mover(event.getX(), event.getY());
                linea.guardarPunto(event.getX(), event.getY());
                break;
            case MotionEvent.ACTION_CANCEL:
                break;
            case MotionEvent.ACTION_UP:
                rectangulo.setxInicial(null);
                rectangulo.setyInicial(null);
                circulo.setxInicial(null);
                circulo.setyInicial(null);
                break;
        }

        return true;
    }

    @Override
    public void surfaceCreated(@NonNull SurfaceHolder surfaceHolder) {
        gameThread = new GameThread(getHolder(), this);
        gameThread.setRunning(true);
    }

    @Override
    public void surfaceChanged(@NonNull SurfaceHolder surfaceHolder, int i, int i1, int i2) {

    }

    @Override
    public void surfaceDestroyed(@NonNull SurfaceHolder surfaceHolder) {
        boolean retry = true;
        gameThread.setRunning(false);

        while(retry) {
            try {
                gameThread.join();
                retry = false;
            } catch (InterruptedException e) {

            }
        }
    }
}
