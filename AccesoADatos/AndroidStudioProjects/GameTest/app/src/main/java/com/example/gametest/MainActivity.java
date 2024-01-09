package com.example.gametest;

import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.os.Bundle;
import android.os.Handler;
import android.os.Looper;
import android.view.MotionEvent;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.FrameLayout;
import android.widget.TextView;

import org.w3c.dom.Text;

import java.util.Random;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class MainActivity extends Activity implements View.OnTouchListener {

    TextView textView;
    StringBuilder builder = new StringBuilder();

    @Override
    public boolean onTouch(View v, MotionEvent event) {
        builder.setLength(0);

        switch (event.getAction()) {
            case MotionEvent.ACTION_DOWN:
                builder.append("Has pulsado.\n");
                break;
            case MotionEvent.ACTION_MOVE:
                builder.append("Estás moviendo.\n");
                break;
            case MotionEvent.ACTION_CANCEL:
                builder.append("Has cancelado.\n");
                break;
            case MotionEvent.ACTION_UP:
                builder.append("Has subido.\n");
                break;
        }
        builder.append("X: ");
        builder.append(event.getX());
        builder.append("\nY: ");
        builder.append(event.getY());
        textView.setText(builder);

        return true;
    }

    /*private void updateCoordinates() {
        ExecutorService executor = Executors.newSingleThreadExecutor();
        Handler handler = new Handler(Looper.getMainLooper());

        executor.execute(new Runnable() {
            @Override
            public void run() {
                handler.post(new Runnable() {
                    @Override
                    public void run() {
                        textView.setText(builder);
                    }
                });
            }
        });
    }*/

    class RenderView extends View {
        Random random = new Random();
        Paint paint = new Paint();

        public RenderView(Context context) {
            super(context);
            textView = new TextView(context);
            textView.setTextColor(Color.BLACK);
            textView.setTextSize(20);
        }

        protected  void onDraw(Canvas canvas) {
            //canvas.drawRGB(random.nextInt(256), random.nextInt(256), random.nextInt(256));

            canvas.drawRGB(255, 255, 255);
            paint.setColor(Color.RED);
            paint.setStrokeWidth(20);
            canvas.drawLine(0, 0, canvas.getWidth() - 1, canvas.getHeight() - 1, paint);

            paint.setStyle(Paint.Style.STROKE);
            paint.setColor(0xff00ff00);
            canvas.drawCircle(canvas.getWidth() / 2, canvas.getHeight() / 2, 40, paint);

            paint.setStyle(Paint.Style.FILL);
            paint.setColor(0x770000ff);
            canvas.drawRect(100, 100, 200, 200, paint);

            invalidate();
        }
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);

        FrameLayout frameLayout = new FrameLayout(this);
        RenderView renderView = new RenderView(this);
        frameLayout.addView(renderView);

        textView = new TextView(this);
        textView.setText("Desliza el dedo");
        textView.setOnTouchListener(this);
        frameLayout.addView(textView);

        setContentView(frameLayout);
    }
}