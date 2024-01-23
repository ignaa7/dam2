package com.example.juegounirfiguras;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.view.MotionEvent;
import android.view.SurfaceHolder;
import android.view.SurfaceView;

import androidx.annotation.NonNull;

import com.example.juegounirfiguras.clases.Circulo;
import com.example.juegounirfiguras.clases.Figura;
import com.example.juegounirfiguras.clases.Rectangulo;

import java.util.ArrayList;
import java.util.List;

public class VistaSurfaceView extends SurfaceView implements SurfaceHolder.Callback {
    private GameThread gameThread;
    private Rectangulo rectangulo;
    private Circulo circulo;
    private Paint paint;
    private List<Figura> figuras = new ArrayList<>();

    //canvas.drawText


    public VistaSurfaceView(Context context) {
        super(context);
        rectangulo = new Rectangulo(200, 400, 700, 500);
        figuras.add(rectangulo);

        circulo = new Circulo(100, 100, 100);
        figuras.add(circulo);

        paint = new Paint();
        setBackgroundColor(Color.BLACK);
    }

    @Override
    protected void onDraw(Canvas canvas) {
        super.onDraw(canvas);
        canvas.drawColor(Color.WHITE);

        for (Figura figura : figuras) {
            figura.onDraw(canvas, paint);
        }

        invalidate();
    }

    @Override
    public boolean onTouchEvent(MotionEvent event) {
        switch (event.getAction()) {
            case MotionEvent.ACTION_DOWN:
                for (Figura figura : figuras) {
                    if (figura.isHovered(event.getX(), event.getY())) {
                        figura.setxInicial(event.getX());
                        figura.setyInicial(event.getY());
                    }
                }

                break;
            case MotionEvent.ACTION_MOVE:
                for (Figura figura : figuras) {
                    figura.mover(event.getX(), event.getY());
                }

                break;
            case MotionEvent.ACTION_CANCEL:
                break;
            case MotionEvent.ACTION_UP:
                for (Figura figura : figuras) {
                    figura.setxInicial(null);
                    figura.setyInicial(null);
                }

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
