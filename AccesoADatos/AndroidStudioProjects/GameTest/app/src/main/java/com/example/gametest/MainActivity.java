package com.example.gametest;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.graphics.Canvas;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;

import java.util.Random;

public class MainActivity extends AppCompatActivity {

    class RenderView extends View {
        Random random = new Random();

        public RenderView(Context context) {
            super(context);
        }

        protected  void OnDraw(Canvas canvas) {
            canvas.drawRGB(random.nextInt(256), random.nextInt(256), random.nextInt(256));

            invalidate();
        }
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);
        setContentView(new RenderView(this));
    }
}