package com.example.pruebamoversprites;

import android.graphics.Canvas;
import android.view.SurfaceHolder;

public class GameThread extends Thread {
    static final long FPS = 10;
    private SurfaceHolder surfaceHolder;
    private MoverSprites moverSprites;
    private boolean run;

    public GameThread(SurfaceHolder surfaceHolder, MoverSprites moverSprites) {
        this.surfaceHolder = surfaceHolder;
        this.moverSprites = moverSprites;
        run = false;
    }

    public void setRunning(boolean run) {
        this.run = run;
    }

    public void run() {
        long ticksPS = 1000 / FPS;
        long startTime;
        long sleepTime;

        Canvas canvas;

        while (run) {
            canvas = null;
            startTime = System.currentTimeMillis();

            try {
                    canvas = surfaceHolder.lockCanvas(null);

                    if (canvas != null) {
                        synchronized (surfaceHolder) {
                            //moverSprites.draw(canvas);
                            moverSprites.postInvalidate();
                        }
                    }

            } finally {
                if (canvas != null) {
                    surfaceHolder.unlockCanvasAndPost(canvas);
                }
            }

            sleepTime = ticksPS - (System.currentTimeMillis() - startTime);

            try {
                if (sleepTime > 0) {
                    sleep(sleepTime);
                }
                else {
                    sleep(10);
                }
            } catch (Exception e) {

            }
        }

    }
}
