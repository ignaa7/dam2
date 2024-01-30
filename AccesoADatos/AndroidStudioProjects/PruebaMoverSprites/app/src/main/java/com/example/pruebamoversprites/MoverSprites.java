package com.example.pruebamoversprites;

import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.view.MotionEvent;
import android.view.SurfaceHolder;
import android.view.SurfaceView;

import androidx.annotation.NonNull;

import java.util.ArrayList;
import java.util.List;

public class MoverSprites extends SurfaceView implements SurfaceHolder.Callback {
    private GameThread gameThread;
    private Sprite sprite;


    public MoverSprites(Context context) {
        super(context);
        setBackgroundColor(Color.BLACK);
        getHolder().addCallback(this);

    }

    @Override
    protected void onDraw(Canvas canvas) {
        super.onDraw(canvas);

        sprite.onDraw(canvas);

    }

    @Override
    public boolean onTouchEvent(MotionEvent event) {
        return true;
    }

    @Override
    public void surfaceCreated(@NonNull SurfaceHolder surfaceHolder) {
        gameThread = new GameThread(getHolder(), this);
        gameThread.setRunning(true);
        gameThread.start();

        Bitmap bitmap = BitmapFactory.decodeResource(getResources(), R.drawable.bad3);
        sprite = new Sprite(this, bitmap);
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
