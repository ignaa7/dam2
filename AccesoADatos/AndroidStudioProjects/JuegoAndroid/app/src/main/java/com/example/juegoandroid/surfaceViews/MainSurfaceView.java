package com.example.juegoandroid.surfaceViews;

import android.content.Context;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.graphics.RectF;
import android.os.Handler;
import android.os.Looper;
import android.view.MotionEvent;
import android.view.SurfaceHolder;
import android.view.SurfaceView;

import androidx.annotation.NonNull;

import com.example.juegoandroid.GameScreen;
import com.example.juegoandroid.MenuScreen;
import com.example.juegoandroid.R;
import com.example.juegoandroid.threads.MainActivityThread;

import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class MainSurfaceView extends SurfaceView implements SurfaceHolder.Callback {
    private MainActivityThread mainActivityThread;
    private Bitmap backgroundImage;
    private Paint paint;
    private String messageText;
    private int textAlpha;
    private int textAlphaVariation = 20;

    public MainSurfaceView(Context context) {
        super(context);
        setBackgroundColor(Color.BLACK);
        getHolder().addCallback(this);
    }

    @Override
    protected void onDraw(Canvas canvas) {
        super.onDraw(canvas);

        if (backgroundImage != null) {
            float scaleWidth = (float) getWidth() / backgroundImage.getWidth();
            float scaleHeight = (float) getHeight() / backgroundImage.getHeight();

            float scaleFactor = Math.min(scaleWidth, scaleHeight);

            float newWidth = backgroundImage.getWidth() * scaleFactor;
            float newHeight = backgroundImage.getHeight() * scaleFactor;

            float x = (getWidth() - newWidth) / 2;
            float y = (getHeight() - newHeight) / 2;

            canvas.drawBitmap(backgroundImage, null, new RectF(x, y, x + newWidth, y + newHeight), null);
        }

        float textWidth = paint.measureText(messageText);
        float x = (canvas.getWidth() - textWidth) / 2;
        float y = (canvas.getHeight() / 2) - ((paint.descent() + paint.ascent()) / 2);

        paint.setColor(Color.argb(textAlpha, Color.red(paint.getColor()), Color.green(paint.getColor()), Color.blue(paint.getColor())));

        if (textAlpha + textAlphaVariation > 255 || textAlpha + textAlphaVariation < 0) {
            textAlphaVariation *= -1;
        }

        textAlpha += textAlphaVariation;

        canvas.drawText(messageText, x, y, paint);
    }

    @Override
    public boolean onTouchEvent(MotionEvent event) {
        if (event.getAction() == MotionEvent.ACTION_DOWN) {
            getContext().startActivity(new Intent(getContext(), MenuScreen.class));
            return true;
        }
        return super.onTouchEvent(event);
    }

    @Override
    public void surfaceCreated(@NonNull SurfaceHolder holder) {
        mainActivityThread = new MainActivityThread(getHolder(), this);
        mainActivityThread.setRunning(true);
        mainActivityThread.start();

        backgroundImage = BitmapFactory.decodeResource(getResources(), R.drawable.main_background);
        paint = new Paint();
        paint.setTextSize(50);
        paint.setColor(Color.BLACK);
        messageText = "";

        showMessageAfterTime();
    }

    @Override
    public void surfaceChanged(@NonNull SurfaceHolder holder, int format, int width, int height) {

    }

    @Override
    public void surfaceDestroyed(@NonNull SurfaceHolder holder) {
        boolean retry = true;
        mainActivityThread.setRunning(false);

        while(retry) {
            try {
                mainActivityThread.join();
                retry = false;
            } catch (InterruptedException e) {

            }
        }
    }

    private void showMessageAfterTime() {
        ExecutorService executor = Executors.newSingleThreadExecutor();

        executor.execute(() -> {
            try {
                for (int i = 0; i < 5; i++) {
                    Thread.sleep(1000);
                }
            }
            catch (InterruptedException e) {
                throw new RuntimeException(e);
            }

            textAlpha = 0;
            messageText = "Pulse para continuar...";
        });
    }
}
