package com.example.juegounirfiguras;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.view.MotionEvent;
import android.view.SurfaceHolder;
import android.view.SurfaceView;

import androidx.annotation.NonNull;

import com.example.juegounirfiguras.clases.Circle;
import com.example.juegounirfiguras.clases.Shape;
import com.example.juegounirfiguras.clases.Rectangle;

import java.util.ArrayList;
import java.util.List;

public class VistaSurfaceView extends SurfaceView implements SurfaceHolder.Callback {
    private GameThread gameThread;
    private Paint paint;
    private List<Shape> shapes = new ArrayList<>();

    //canvas.drawText


    public VistaSurfaceView(Context context) {
        super(context);

        paint = new Paint();
        setBackgroundColor(Color.BLACK);
    }

    private void generateRandomShape() {
        int randomShapeNumber = (int) (Math.random() * 2);

        if (randomShapeNumber == 0) {
            shapes.add(new Circle(100, 100, 100));
        } else {
            shapes.add(new Rectangle(200, 400, 100, 100));
        }
    }

    @Override
    protected void onDraw(Canvas canvas) {
        super.onDraw(canvas);
        canvas.drawColor(Color.WHITE);

        for (Shape shape : shapes) {
            shape.onDraw(canvas, paint);
        }

        invalidate();
    }

    @Override
    public boolean onTouchEvent(MotionEvent event) {
        switch (event.getAction()) {
            case MotionEvent.ACTION_DOWN:
                for (Shape shape : shapes) {
                    if (shape.isHovered(event.getX(), event.getY())) {
                        shape.setxInicial(event.getX());
                        shape.setyInicial(event.getY());
                    }
                }

                break;
            case MotionEvent.ACTION_MOVE:
                for (Shape shape : shapes) {
                    shape.mover(event.getX(), event.getY());
                }

                break;
            case MotionEvent.ACTION_CANCEL:
                break;
            case MotionEvent.ACTION_UP:
                for (Shape shape : shapes) {
                    shape.setxInicial(null);
                    shape.setyInicial(null);
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
