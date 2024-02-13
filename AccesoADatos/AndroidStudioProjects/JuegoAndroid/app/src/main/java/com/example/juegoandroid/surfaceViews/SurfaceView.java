package com.example.juegoandroid.surfaceViews;

import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.graphics.Color;
import android.view.MotionEvent;
import android.view.SurfaceHolder;

import androidx.annotation.NonNull;

import com.example.juegoandroid.threads.GameThread;

import java.util.ArrayList;
import java.util.List;

public class SurfaceView extends android.view.SurfaceView implements SurfaceHolder.Callback {
    private GameThread gameThread;
    //private Sprite spriteBread;
    //private Sprite spriteBurguer;
    //private Sprite spriteFries;
    private List<Sprite> sprites = new ArrayList<Sprite>();
    private List<Sangre> sangres = new ArrayList<Sangre>();
    private long lastClick = 0;
    private Bitmap bitmapSangre;


    public SurfaceView(Context context) {
        super(context);
        setBackgroundColor(Color.BLACK);
        getHolder().addCallback(this);
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

        for (int i = sangres.size() - 1; i >= 0; i--) {
            sangres.get(i).onDraw(canvas);
        }
    }

    @Override
    public boolean onTouchEvent(MotionEvent event) {
        switch (event.getAction()) {
            case MotionEvent.ACTION_DOWN:
                if (System.currentTimeMillis() - lastClick > 500) {
                    lastClick = System.currentTimeMillis();

                    boolean encontrado = false;

                    synchronized (sprites) {
                        for (int i = sprites.size() - 1; i >= 0 && !encontrado; i--) {
                            Sprite sprite = sprites.get(i);
                            if (sprite.isCollition(event.getX(), event.getY())) {
                                sprites.remove(sprite);
                                sangres.add(new Sangre(event.getX(), event.getY(), bitmapSangre, this, sangres));
                                encontrado = true;
                            }
                        }
                    }
                }

                break;
            case MotionEvent.ACTION_MOVE:
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
        gameThread.start();

        Bitmap bitmap = BitmapFactory.decodeResource(getResources(), R.drawable.bad3);
        sprite = new Sprite(this, bitmap);

        bitmapSangre = BitmapFactory.decodeResource(getResources(), R.drawable.blood1);

        createSprites();
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
