package com.example.juegounirfiguras;

import android.graphics.Canvas;
import android.view.SurfaceHolder;

public class GameThread extends Thread {
    private SurfaceHolder surfaceHolder;
    private VistaSurfaceView vistaSurfaceView;
    private boolean run;

    public GameThread(SurfaceHolder surfaceHolder, VistaSurfaceView vistaSurfaceView) {
        this.surfaceHolder = surfaceHolder;
        this.vistaSurfaceView = vistaSurfaceView;
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
                        vistaSurfaceView.draw(canvas);
                    }
                }
            } finally {
                if (canvas != null) {
                    surfaceHolder.unlockCanvasAndPost(canvas);
                }
            }
        }

        vistaSurfaceView.postInvalidate();
    }
}
