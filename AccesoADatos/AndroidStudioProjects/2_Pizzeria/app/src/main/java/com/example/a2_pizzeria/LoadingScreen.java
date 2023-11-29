package com.example.a2_pizzeria;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;

import com.example.a2_pizzeria.databinding.ActivityConfirmationScreenBinding;
import com.example.a2_pizzeria.databinding.ActivityLoadingScreenBinding;

public class LoadingScreen extends AppCompatActivity {

    private ActivityLoadingScreenBinding binding;

    private Executor executor = Executors.newFixedThreadPool(2); // Adjust the pool size as needed
    private ProgressBar loadingCircle;
    private Button showTicketButton;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_loading_screen);

        binding = ActivityLoadingScreenBinding.inflate(getLayoutInflater());
        View view = binding.getRoot();
        setContentView(view);
    }

    private void executeBackgroundTasks() {
        // Show loading circle while background tasks are running
        loadingCircle.setVisibility(View.VISIBLE);

        executor.execute(new Runnable() {
            @Override
            public void run() {
                // Background task 1: Perform some operation
                // ...

                runOnUiThread(new Runnable() {
                    @Override
                    public void run() {
                        // Update UI or perform any UI-related tasks after task 1
                        // ...
                    }
                });
            }
        });

        executor.execute(new Runnable() {
            @Override
            public void run() {
                // Background task 2: Perform another operation
                // ...

                runOnUiThread(new Runnable() {
                    @Override
                    public void run() {
                        // Update UI or perform any UI-related tasks after task 2
                        // ...

                        // Hide the loading circle when both tasks are complete
                        loadingCircle.setVisibility(View.GONE);
                    }
                });
            }
        });
    }
}