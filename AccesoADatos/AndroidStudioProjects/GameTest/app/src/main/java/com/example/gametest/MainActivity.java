package com.example.gametest;

import androidx.appcompat.app.AppCompatActivity;

import android.app.Activity;
import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.os.Bundle;
import android.view.MotionEvent;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.TextView;

import org.w3c.dom.Text;

import java.util.Random;

public class MainActivity extends Activity implements View.OnTouchListener {

    TextView textView;

    @Override
    public boolean onTouch(View v, MotionEvent event) {
        StringBuilder builder = new StringBuilder();

        switch (event.getAction()) {
            case MotionEvent.ACTION_DOWN:
                builder.setLength(0);
                builder.append("X: ");
                builder.append(event.getX());
                builder.append("\nY: ");
                builder.append(event.getY());
                textView.setText(builder);
            case MotionEvent.ACTION_MOVE:
                builder.setLength(0);
                builder.append("X: ");
                builder.append(event.getX());
                builder.append("\nY: ");
                builder.append(event.getY());
                textView.setText(builder);
            case MotionEvent.ACTION_CANCEL:
                builder.setLength(0);
                builder.append("X: ");
                builder.append(event.getX());
                builder.append("\nY: ");
                builder.append(event.getY());
                textView.setText(builder);
            case MotionEvent.ACTION_UP:
                builder.setLength(0);
                builder.append("X: ");
                builder.append(event.getX());
                builder.append("\nY: ");
                builder.append(event.getY());
                textView.setText(builder);
        }
        return true;
    }

    class RenderView extends View {
        Random random = new Random();
        Paint paint = new Paint();

        public RenderView(Context context) {
            super(context);
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
        textView.setText("Desliza el dedo");
        textView.setOnTouchListener(this);
        setContentView(new RenderView(this));

        /*textView = new TextView(this);
        textView.setText("Desliza el dedo");
        textView.setOnTouchListener(this);
        setContentView(textView);*/
    }
}