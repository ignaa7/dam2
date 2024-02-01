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
    private List<Sprite> sprites = new ArrayList<Sprite>();
    private long lastClick = 0;
    private Bitmap bitmapSangre;


    public MoverSprites(Context context) {
        super(context);
        setBackgroundColor(Color.BLACK);
        getHolder().addCallback(this);

        createSprites();
    }

    private void createSprites() {
        sprites.add(createSprite(R.drawable.bad1));
        sprites.add(createSprite(R.drawable.bad2));
        sprites.add(createSprite(R.drawable.bad3));
        sprites.add(createSprite(R.drawable.bad4));
        sprites.add(createSprite(R.drawable.bad5));
        sprites.add(createSprite(R.drawable.bad6));
        sprites.add(createSprite(R.drawable.good1));
        sprites.add(createSprite(R.drawable.good2));
        sprites.add(createSprite(R.drawable.good3));
        sprites.add(createSprite(R.drawable.good4));
        sprites.add(createSprite(R.drawable.good5));
        sprites.add(createSprite(R.drawable.good6));
    }

    private Sprite createSprite(int resource) {
        Bitmap bitmap = BitmapFactory.decodeResource(getResources(), resource);
        return new Sprite(this, bitmap);
    }

    @Override
    protected void onDraw(Canvas canvas) {
        canvas.drawColor(Color.BLACK);

        for (Sprite sprite : sprites) {
            sprite.onDraw(canvas);
        }

    }

    @Override
    public boolean onTouchEvent(MotionEvent event) {
        if (System.currentTimeMillis() - lastClick > 500) {
            lastClick = System.currentTimeMillis();

            boolean encontrado = false;

            synchronized (sprites) {
                for (int i = sprites.size() - 1; i >= 0 && !encontrado; i--) {
                    Sprite sprite = sprites.get(i);
                    if (sprite.isCollition(event.getX(), event.getY())) {
                        sprites.remove(sprite);
                        encontrado = true;
                    }
                }
            }
        }

        return true;
    }

    @Override
    public void surfaceCreated(@NonNull SurfaceHolder surfaceHolder) {
        gameThread = new GameThread(getHolder(), this);
        gameThread.setRunning(true);
        gameThread.start();

        Bitmap bitmap = BitmapFactory.decodeResource(getResources(), R.drawable.bad3);
        sprite = new Sprite(this, bitmap);

        bitmapSangre = BitmapFactory.decodeResource(getResources(), R.drawable.blood1);
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
