package com.example.juegoandroid.threads;

import android.graphics.Canvas;
import android.view.SurfaceHolder;

import com.example.juegoandroid.surfaceViews.GameSurfaceView;

public class GameThread extends Thread {
    static final long FPS = 10;
    private SurfaceHolder surfaceHolder;
    private GameSurfaceView gameSurfaceView;
    private boolean run;

    public GameThread(SurfaceHolder surfaceHolder, GameSurfaceView gameSurfaceView) {
        this.surfaceHolder = surfaceHolder;
        this.gameSurfaceView = gameSurfaceView;
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
                        gameSurfaceView.postInvalidate();
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
