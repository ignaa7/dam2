package com.example.pruebamoverfiguras;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.view.MotionEvent;
import android.view.SurfaceHolder;
import android.view.SurfaceView;

import androidx.annotation.NonNull;

public class MoverFiguras extends SurfaceView implements SurfaceHolder.Callback {
    private GameThread gameThread;
    private Rectangulo rectangulo;
    private Paint paint;


    public MoverFiguras(Context context) {
        super(context);
        rectangulo = new Rectangulo(200, 400, 700, 500);
        paint = new Paint();
        setBackgroundColor(Color.BLACK);
    }

    @Override
    protected void onDraw(Canvas canvas) {
        super.onDraw(canvas);

        invalidate();
    }

    @Override
    public boolean onTouchEvent(MotionEvent event) {
        //return super.onTouchEvent(event);
        switch (event.getAction()) {
            case MotionEvent.ACTION_DOWN:
                if (rectangulo.isHovered(event.getX(), event.getY())) {
                    xInicial = event.getX();
                    yInicial = event.getY();
                }
                break;
            case MotionEvent.ACTION_MOVE:
                float desplazamientoX = event.getX() - xInicial;
                float desplazamientoY = event.getY() - yInicial;
                xInicial = event.getX();
                yInicial = event.getY();
                rectangulo.moverRectangulo(desplazamientoX, desplazamientoY);
                break;
            case MotionEvent.ACTION_CANCEL:
                break;
            case MotionEvent.ACTION_UP:
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
