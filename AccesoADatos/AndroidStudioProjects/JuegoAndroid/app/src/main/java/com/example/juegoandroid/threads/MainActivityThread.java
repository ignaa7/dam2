package com.example.juegoandroid.threads;

import android.graphics.Canvas;
import android.view.SurfaceHolder;

import com.example.juegoandroid.surfaceViews.MainSurfaceView;

public class MainActivityThread extends Thread {
    static final long FPS = 10;
    private SurfaceHolder surfaceHolder;
    private MainSurfaceView mainSurfaceView;
    private boolean run;

    public MainActivityThread(SurfaceHolder surfaceHolder, MainSurfaceView mainSurfaceView) {
        this.surfaceHolder = surfaceHolder;
        this.mainSurfaceView = mainSurfaceView;
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
                        mainSurfaceView.postInvalidate();
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
