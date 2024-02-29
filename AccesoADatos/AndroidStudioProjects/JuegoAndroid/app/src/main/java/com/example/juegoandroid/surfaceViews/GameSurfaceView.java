package com.example.juegoandroid.surfaceViews;

import android.app.Activity;
import android.content.Context;
import android.content.SharedPreferences;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.graphics.RectF;
import android.media.MediaPlayer;
import android.view.MotionEvent;
import android.view.SurfaceHolder;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AlertDialog;

import com.example.juegoandroid.R;
import com.example.juegoandroid.dao.DbHelper;
import com.example.juegoandroid.models.Bread;
import com.example.juegoandroid.models.BreadBox;
import com.example.juegoandroid.models.BurguerMeat;
import com.example.juegoandroid.models.BurguerBox;
import com.example.juegoandroid.models.Coin;
import com.example.juegoandroid.models.CompleteBurguer;
import com.example.juegoandroid.models.Grill;
import com.example.juegoandroid.models.Table;
import com.example.juegoandroid.threads.GameThread;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class GameSurfaceView extends android.view.SurfaceView implements SurfaceHolder.Callback {
    private GameThread gameThread;
    private Bitmap backgroundImage;
    private Bitmap burguerBitmap;
    private Bitmap fireBitmap;
    private Bitmap smokedBitmap;
    private Map<Integer, BurguerMeat> burguerMeats = new HashMap<>();
    private Bread bread;
    private CompleteBurguer completeBurguer;
    private List<Grill> grills = new ArrayList<>();
    private BurguerBox burguerBox;
    private BreadBox breadBox;
    private Table table;
    private Coin coin;
    private SharedPreferences upgradesPreferences;
    private Paint paint;
    private int counter;
    private int price;
    private int coins;
    private MediaPlayer music;
    private MediaPlayer grillSound;
    private MediaPlayer bellSound;


    public GameSurfaceView(Context context) {
        super(context);
        setBackgroundColor(Color.BLACK);
        getHolder().addCallback(this);

        upgradesPreferences = getContext().getSharedPreferences("upgrades", Context.MODE_PRIVATE);
//        SharedPreferences.Editor editor = upgradesPreferences.edit();
//        editor.putInt("counter", 15);
//        editor.putInt("price", 5);
//        editor.putInt("grillsNumber", 2);
//        editor.putInt("cookingTime", 4);
//        editor.apply();

        counter = upgradesPreferences.getInt("time", 15);
        price = upgradesPreferences.getInt("price", 5);

        paint = new Paint();
        paint.setColor(Color.BLACK);
        paint.setTextSize(100);
        paint.setTextAlign(Paint.Align.CENTER);

        coins = 0;

        music = MediaPlayer.create(getContext(), R.raw.game);
        music.start();
        music.setLooping(true);
        grillSound = MediaPlayer.create(getContext(), R.raw.grill);
        bellSound = MediaPlayer.create(getContext(), R.raw.bell);
    }

    private void createGrills() {
        int grillsNumber = upgradesPreferences.getInt("grillsNumber", 2);

        for (int i = 0; i < grillsNumber; i++) {
            grills.add(createGrill(i, R.drawable.grill));
        }
    }

    private Grill createGrill(int i, int resource) {
        Bitmap bitmap = BitmapFactory.decodeResource(getResources(), resource);
        return new Grill(i, this, bitmap);
    }

    private void createBoxes() {
        Bitmap bitmap = BitmapFactory.decodeResource(getResources(), R.drawable.burguer_box);
        burguerBox = new BurguerBox(this, bitmap);

        bitmap = BitmapFactory.decodeResource(getResources(), R.drawable.bread_box);
        breadBox = new BreadBox(this, bitmap);
    }

    private void createTable() {
        Bitmap bitmap = BitmapFactory.decodeResource(getResources(), R.drawable.table);
        table = new Table(this, bitmap);
    }

    private void createCoin() {
        Bitmap bitmap = BitmapFactory.decodeResource(getResources(), R.drawable.coin);
        coin = new Coin(this, bitmap);
    }

    @Override
    protected void onDraw(Canvas canvas) {
        canvas.drawColor(Color.BLACK);

        if (backgroundImage != null) {
            float scaleWidth = (float) getWidth() / backgroundImage.getWidth();
            float scaleHeight = (float) getHeight() / backgroundImage.getHeight();

            float scaleFactor = Math.max(scaleWidth, scaleHeight);

            float newWidth = backgroundImage.getWidth() * scaleFactor;
            float newHeight = backgroundImage.getHeight() * scaleFactor;

            float x = (getWidth() - newWidth) / 2;
            float y = (getHeight() - newHeight) / 2;

            canvas.drawBitmap(backgroundImage, null, new RectF(x, y, x + newWidth, y + newHeight), null);
        }

        for (Grill grill : grills) {
            grill.onDraw(canvas);
        }

        if (burguerBox != null) {
            burguerBox.onDraw(canvas);
        }

        if (breadBox != null) {
            breadBox.onDraw(canvas);
        }

        if (table != null) {
            table.onDraw(canvas);
        }

        for (BurguerMeat burguerMeat : burguerMeats.values()) {
            burguerMeat.onDraw(canvas);
        }

        if (bread != null) {
            bread.onDraw(canvas);
        }

        if (completeBurguer != null) {
            completeBurguer.onDraw(canvas);
        }

        canvas.drawText(String.valueOf(counter), getWidth() / 2f, 100, paint);

        coin.onDraw(canvas);
        canvas.drawText(String.valueOf(coins), getWidth() * 0.85f + coin.getWidth() * 2, 100, paint);
    }

    @Override
    public boolean onTouchEvent(MotionEvent event) {
        switch (event.getAction()) {
            case MotionEvent.ACTION_DOWN:
                    float touchedX = event.getX();
                    float touchedY = event.getY();

                    if (breadBox.isTouched(touchedX, touchedY)) {
                        if (bread == null && completeBurguer == null) {
                            bread = new Bread(this, burguerBitmap);
                        }
                    }

                    if (burguerBox.isTouched(touchedX, touchedY)) {
                        boolean found = false;

                        for (int key = 0; key < grills.size() && !found; key++) {
                            if (!burguerMeats.containsKey(key)) {
                                if (burguerMeats.isEmpty()) {
                                    grillSound.start();
                                    grillSound.setLooping(true);
                                }
                                burguerMeats.put(key, new BurguerMeat(this, burguerBitmap, fireBitmap, smokedBitmap, key));
                                found = true;
                            }
                        }
                    }

                Iterator<Map.Entry<Integer, BurguerMeat>> iterator = burguerMeats.entrySet().iterator();
                while (iterator.hasNext()) {
                    Map.Entry<Integer, BurguerMeat> entry = iterator.next();
                    BurguerMeat burguerMeat = entry.getValue();
                    if (burguerMeat.isTouched(touchedX, touchedY)) {
                        if (!burguerMeat.isBurnt()) {
                            if (burguerMeat.isCooked() && bread != null) {
                                bread = null;
                                completeBurguer = new CompleteBurguer(this, burguerBitmap);
                                iterator.remove();

                                if (burguerMeats.isEmpty()) {
                                    grillSound.stop();
                                }
                            }
                        } else {
                            iterator.remove();
                            if (burguerMeats.isEmpty()) {
                                grillSound.stop();
                            }
                        }
                    }
                }

                if (completeBurguer != null) {
                    if (completeBurguer.isTouched(touchedX, touchedY)) {
                        completeBurguer = null;
                        coins += price;
                        bellSound.start();
                    }
                }

                break;
            case MotionEvent.ACTION_MOVE:
                break;
            case MotionEvent.ACTION_CANCEL:
                break;
            case MotionEvent.ACTION_UP:
                break;
        }

        return true;
    }

    @Override
    public void surfaceCreated(@NonNull SurfaceHolder surfaceHolder) {
        gameThread = new GameThread(getHolder(), this);
        gameThread.setRunning(true);
        gameThread.start();

        backgroundImage = BitmapFactory.decodeResource(getResources(), R.drawable.grass_background);
        burguerBitmap = BitmapFactory.decodeResource(getResources(), R.drawable.burguer);
        fireBitmap = BitmapFactory.decodeResource(getResources(), R.drawable.fire);
        smokedBitmap = BitmapFactory.decodeResource(getResources(), R.drawable.smoke);

        createGrills();
        createBoxes();
        createTable();
        createCoin();

        startCounter();
    }

    @Override
    public void surfaceChanged(@NonNull SurfaceHolder surfaceHolder, int i, int i1, int i2) {

    }

    @Override
    public void surfaceDestroyed(@NonNull SurfaceHolder surfaceHolder) {
        boolean retry = true;
        gameThread.setRunning(false);

        while(retry) {
            try {
                gameThread.join();
                retry = false;
            } catch (InterruptedException e) {

            }
        }
    }

    private void startCounter() {
        ExecutorService executor = Executors.newSingleThreadExecutor();

        executor.execute(() -> {
            try {
                for (int i = counter; i > 0; i--) {
                    counter--;
                    Thread.sleep(1000);
                }
            }
            catch (InterruptedException e) {
                throw new RuntimeException(e);
            }

            music.stop();
            grillSound.stop();
            music = MediaPlayer.create(getContext(), R.raw.ending);
            music.start();
            music.setLooping(true);

            ((Activity) getContext()).runOnUiThread(() -> {
                SharedPreferences currentUserPreferences = getContext().getSharedPreferences("currentUser", Context.MODE_PRIVATE);
                String username = currentUserPreferences.getString("username", "");

                DbHelper dbHelper = new DbHelper(getContext());
                boolean isBestScore = dbHelper.checkScore(username, coins);

                String message = "Ha conseguido " + coins + " monedas.";
                if (isBestScore) {
                    message += " ¡Es su nuevo récord!";
                }

                AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(getContext());

                alertDialogBuilder.setTitle("Tiempo agotado");
                alertDialogBuilder.setMessage(message);

                alertDialogBuilder.setPositiveButton("Aceptar", (dialog, which) -> {
                    music.stop();
                    ((Activity)getContext()).finish();
                });

                AlertDialog alertDialog = alertDialogBuilder.create();
                alertDialog.show();
            });

        });
    }
}
