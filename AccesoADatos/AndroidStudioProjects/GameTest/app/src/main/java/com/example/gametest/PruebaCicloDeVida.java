package com.example.gametest;

import android.app.Activity;
import android.os.Bundle;
import android.util.Log;
import android.widget.TextView;

import androidx.annotation.Nullable;

public class PruebaCicloDeVida extends Activity {
    StringBuilder builder = new StringBuilder();
    TextView textView;

    private void log(String text) {
        Log.d("LifeCycleTest", text);
        builder.append(text);
        builder.append('\n');
        textView.setText(builder.toString());
    }

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        textView = new TextView(this);
        textView.setText(builder.toString());
        setContentView(textView);
        log("Created");
    }

    @Override
    protected void onResume() {
        super.onResume();
        log("Resume");
    }

    @Override
    protected void onPause() {
        super.onPause();
        log("Paused");

        if (isFinishing()) {
            log("Finishing");
        }
    }
}
