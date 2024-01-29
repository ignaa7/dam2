package com.example.juegounirfiguras;

import android.graphics.Canvas;
import android.view.SurfaceHolder;

public class GameThread extends Thread {
    private SurfaceHolder surfaceHolder;
    private SurfaceView surfaceView;
    private boolean run;

    public GameThread(SurfaceHolder surfaceHolder, SurfaceView surfaceView) {
        this.surfaceHolder = surfaceHolder;
        this.surfaceView = surfaceView;
        run = false;
    }

    public void setRunning(boolean run) {
        this.run = run;
    }

    public void run() {
        Canvas canvas;

        while (run) {
            canvas = null;

            try {
                if (canvas != null) {
                    canvas = surfaceHolder.lockCanvas(null);

                    synchronized (surfaceHolder) {
                        surfaceView.draw(canvas);
                    }
                }
            } finally {
                if (canvas != null) {
                    surfaceHolder.unlockCanvasAndPost(canvas);
                }
            }
        }

        surfaceView.postInvalidate();
    }
}
