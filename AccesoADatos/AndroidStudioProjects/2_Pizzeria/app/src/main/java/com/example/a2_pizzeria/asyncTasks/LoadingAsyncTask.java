package com.example.a2_pizzeria.asyncTasks;

import android.os.AsyncTask;
import android.util.Log;
import android.widget.Toast;

import com.example.a2_pizzeria.MainActivity;

public class LoadingAsyncTask extends AsyncTask {
    @Override
    protected String doInBackground(Object[] objects) {
        Log.d("asaa", "sad");
        return "hola";
    }
}
