package com.example.juegounirfiguras;

import android.app.Activity;
import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.util.DisplayMetrics;
import android.view.MotionEvent;
import android.view.SurfaceHolder;

import androidx.annotation.NonNull;

import com.example.juegounirfiguras.clases.Circle;
import com.example.juegounirfiguras.clases.Shape;
import com.example.juegounirfiguras.clases.Rectangle;

import java.util.ArrayList;
import java.util.List;

public class SurfaceView extends android.view.SurfaceView implements SurfaceHolder.Callback {
    private GameThread gameThread;
    private Paint paint;
    private List<Shape> filledShapes = new ArrayList<>();
    private List<Shape> emptyShapes = new ArrayList<>();
    private int screenHeight;
    private int screenWidth;

    //canvas.drawText -> write text in the screen


    public SurfaceView(Context context) {
        super(context);

        DisplayMetrics displayMetrics = new DisplayMetrics();
        ((Activity) getContext()).getWindowManager().getDefaultDisplay().getMetrics(displayMetrics);
        screenHeight = displayMetrics.heightPixels;
        screenWidth = displayMetrics.widthPixels;

        paint = new Paint();
        setBackgroundColor(Color.BLACK);

        generateRandomShape();
    }

    private void generateRandomShape() {
        int randomShapeNumber = (int) (Math.random() * 2);

        if (randomShapeNumber == 0) {
            filledShapes.add(new Circle((float) (Math.random() * screenWidth), (float) (Math.random() * screenHeight), 100, true));
            emptyShapes.add(new Circle((float) (Math.random() * screenWidth), (float) (Math.random() * screenHeight), 100, false));
        } else {
            filledShapes.add(new Rectangle((float) (Math.random() * screenWidth), (float) (Math.random() * screenHeight), 100, 100, true));
            emptyShapes.add(new Rectangle((float) (Math.random() * screenWidth), (float) (Math.random() * screenHeight), 100, 100, false));
        }
    }

    @Override
    protected void onDraw(Canvas canvas) {
        super.onDraw(canvas);
        canvas.drawColor(Color.WHITE);

        for (Shape shape : filledShapes) {
            shape.onDraw(canvas, paint);
        }

        for (Shape shape : emptyShapes) {
            shape.onDraw(canvas, paint);
        }

        invalidate();
    }

    @Override
    public boolean onTouchEvent(MotionEvent event) {
        switch (event.getAction()) {
            case MotionEvent.ACTION_DOWN:
                for (Shape shape : filledShapes) {
                    if (shape.isHovered(event.getX(), event.getY())) {
                        shape.setInitialX(event.getX());
                        shape.setInitialY(event.getY());
                    }
                }

                break;
            case MotionEvent.ACTION_MOVE:
                for (Shape shape : filledShapes) {
                    shape.mover(event.getX(), event.getY());
                }

                break;
            case MotionEvent.ACTION_CANCEL:
                break;
            case MotionEvent.ACTION_UP:
                for (Shape shape : filledShapes) {
                    if (shape.getInitialX() != null && shape.getInitialY() != null) {
                        int index = filledShapes.indexOf(shape);
                        Shape emptyShape = emptyShapes.get(index);

                        if (emptyShape.isNear(shape.getX(), shape.getY())) {
                            shape.setX(emptyShape.getX());
                            shape.setY(emptyShape.getY());
                        }
                    }

                    shape.setInitialX(null);
                    shape.setInitialY(null);
                }

                break;
        }

        return true;
    }

    @Override
    public void surfaceCreated(@NonNull SurfaceHolder surfaceHolder) {
        gameThread = new GameThread(getHolder(), this);
        gameThread.setRunning(true);

        // añadir sprite
        /*Bitmap bmp = BitmapFactory.decodeResource(getResources(), R.drawable.imagen);
        Bitmap img = bmp.createScaledBitmap(bmp, getWidth() * 0.2, getHeight() * 0.2, true);

        Canvas.drawBitmap(img, posX, posY, null);

        sonidos:
        setVolumeControlStream(AudioManager.STREAM_MUSIC);
        soundPool = new SoundPool(20, AudioManager.STREAM_MUSIC, 0);

        onTouch(){
            soundPool.play(explosionId, 1, 1, 0, 0, 1);
        }*/
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
