package com.example.juegounirfiguras;

import androidx.appcompat.app.AppCompatActivity;

import android.content.pm.ActivityInfo;
import android.os.Bundle;
import android.view.Window;
import android.view.WindowManager;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        setRequestedOrientation((ActivityInfo.SCREEN_ORIENTATION_SENSOR_LANDSCAPE));

        requestWindowFeature(Window.FEATURE_NO_TITLE);
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
                WindowManager.LayoutParams.FLAG_FULLSCREEN);

        /*subir y bajar volymen con botones del movil
        setVolumeControlStream(AudioManager.STREAM_MUSIC);

        AssetManager = getAssets();
        R.raw.ejemploaudio -> carpeta de recursos
        devuelve manejador o descriptor a un fichero
        AssetFileDescriptor descriptor = assetManager.openFd("explosion.ogg");
        explosionId = soundPool.load(descriptor, 1);
        soundPool.play(explosionId, 1, 1, 0, 0, 1);*/

        super.onCreate(savedInstanceState);
        setContentView(new SurfaceView(this));
    }
}