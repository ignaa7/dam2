package com.example.juegoandroid.models;

import android.content.Context;
import android.content.SharedPreferences;
import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Rect;

import com.example.juegoandroid.surfaceViews.GameSurfaceView;

import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class BurguerMeat {
    private static final int BURGUER_BITMAP_ROWS = 2;
    private static final int BURGUER_BITMAP_COLUMNS = 2;
    private static final int FIRE_BITMAP_ROWS = 2;
    private static final int FIRE_BITMAP_COLUMNS = 3;
    private static final int SMOKE_BITMAP_ROWS = 3;
    private static final int SMOKE_BITMAP_COLUMNS = 3;
    private int burguerX;
    private int burguerY;
    private int fireX;
    private int fireY;
    private int smokeX;
    private int smokeY;
    private  int burguerWidth;
    private int burguerHeight;
    private  int fireWidth;
    private int fireHeight;
    private  int smokeWidth;
    private int smokeHeight;
    private Rect burguerSrc;
    private Rect burguerDst;
    private Rect fireSrc;
    private Rect fireDst;
    private int fireSpriteNumber = 0;
    private Rect smokeSrc;
    private Rect smokeDst;
    private int smokeSpriteNumber = 0;
    private Bitmap burguerBitmap;
    private Bitmap fireBitmap;
    private Bitmap smokeBitmap;
    private SharedPreferences upgradesPreferences;
    private int cookingTime;
    private int burningTime;
    private boolean isCooked = false;
    private boolean isBurnt = false;

    public BurguerMeat(GameSurfaceView gameSurfaceView, Bitmap burguerBitmap, Bitmap fireBitmap, Bitmap smokeBitmap, Integer grillNumber) {
        this.burguerBitmap = burguerBitmap;
        this.fireBitmap = fireBitmap;
        this.smokeBitmap = smokeBitmap;

        int viewWidth = gameSurfaceView.getWidth();
        int viewHeight = gameSurfaceView.getHeight();

        int bitmapScaledWidth = viewWidth / 6;
        int bitmapScaledHeight = viewHeight  / 3;
        this.burguerBitmap = Bitmap.createScaledBitmap(burguerBitmap, bitmapScaledWidth, bitmapScaledHeight, true);
        this.fireBitmap = Bitmap.createScaledBitmap(fireBitmap, bitmapScaledWidth, bitmapScaledHeight, true);
        this.smokeBitmap = Bitmap.createScaledBitmap(smokeBitmap, bitmapScaledWidth, bitmapScaledHeight, true);

        this.burguerWidth = this.burguerBitmap.getWidth() / BURGUER_BITMAP_COLUMNS;
        this.burguerHeight = this.burguerBitmap.getHeight() / BURGUER_BITMAP_ROWS;
        this.fireWidth = this.fireBitmap.getWidth() / FIRE_BITMAP_COLUMNS;
        this.fireHeight = this.fireBitmap.getHeight() / FIRE_BITMAP_ROWS;
        this.smokeWidth = this.smokeBitmap.getWidth() / SMOKE_BITMAP_COLUMNS;
        this.smokeHeight = this.smokeBitmap.getHeight() / SMOKE_BITMAP_ROWS;

        switch (grillNumber) {
            case 0:
                burguerX = (int) (viewWidth * 0.135);
                burguerY = (int) (viewHeight * 0.21);
                break;
            case 1:
                burguerX = (int) (viewWidth * 0.385);
                burguerY = (int) (viewHeight * 0.21);
                break;
            case 2:
                burguerX = (int) (viewWidth * 0.135);
                burguerY = (int) (viewHeight * 0.64);
                break;
            case 3:
                burguerX = (int) (viewWidth * 0.385);
                burguerY = (int) (viewHeight * 0.64);
                break;
            default:
                break;
        }

        burguerDst = new Rect(burguerX, burguerY, burguerX + burguerWidth, burguerY + burguerHeight);

        fireX = burguerX + (int) (viewWidth * 0.02);
        fireY = burguerY + burguerHeight - fireHeight - (int) (viewWidth * 0.02);
        fireDst = new Rect(fireX, fireY, fireX + fireWidth, fireY + fireHeight);

        smokeX = burguerX + (int) (viewWidth * 0.015);
        smokeY = burguerY - smokeHeight + (int) (viewWidth * 0.01);
        smokeDst = new Rect(smokeX, smokeY, smokeX + smokeWidth, smokeY + smokeHeight);


        upgradesPreferences = gameSurfaceView.getContext().getSharedPreferences("upgrades", Context.MODE_PRIVATE);
        cookingTime = upgradesPreferences.getInt("cookingTime", 4);

        SharedPreferences difficultyPreferences = gameSurfaceView.getContext().getSharedPreferences("difficulty", Context.MODE_PRIVATE);
        String difficulty = difficultyPreferences.getString("difficulty", "easy");

        if (difficulty.equals("easy")) {
            burningTime = 5;
        } else if (difficulty.equals("medium")) {
            burningTime = 3;
        } else if (difficulty.equals("hard")) {
            burningTime = 1;
        }

        toggleState();
    }

    public boolean isCooked() {
        return isCooked;
    }

    public boolean isBurnt() {
        return isBurnt;
    }

    public void onDraw(Canvas canvas) {
        if (isBurnt) {
            switch (fireSpriteNumber) {
                case 1:
                    fireSrc = new Rect(0, 0, fireWidth, fireHeight);
                    break;
                case 2:
                    fireSrc = new Rect(fireWidth, 0, fireWidth * 2, fireHeight);
                    break;
                case 3:
                    fireSrc = new Rect(fireWidth * 2, 0, fireWidth * 3, fireHeight);
                    break;
                case 4:
                    fireSrc = new Rect(0, fireHeight, fireWidth, fireHeight * 2);
                    break;
                case 5:
                    fireSrc = new Rect(fireWidth, fireHeight, fireWidth * 2, fireHeight * 2);
                    break;
                case 6:
                    fireSrc = new Rect(fireWidth * 2, fireHeight, fireWidth * 3, fireHeight * 2);
                    break;
                default:
                    break;
            }
            canvas.drawBitmap(fireBitmap, fireSrc, fireDst, null);
        } else {
            if (!isCooked) {
                burguerSrc = new Rect(0, 0, burguerWidth, burguerHeight);
            } else {
                burguerSrc = new Rect(burguerWidth, 0, burguerWidth * 2, burguerHeight);
            }
            switch (smokeSpriteNumber) {
                case 1:
                    smokeSrc = new Rect(0, 0, smokeWidth, smokeHeight);
                    break;
                case 2:
                    smokeSrc = new Rect(smokeWidth, 0, smokeWidth * 2, smokeHeight);
                    break;
                case 3:
                    smokeSrc = new Rect(smokeWidth * 2, 0, smokeWidth * 3, smokeHeight);
                    break;
                case 4:
                    smokeSrc = new Rect(0, smokeHeight, smokeWidth, smokeHeight * 2);
                    break;
                case 5:
                    smokeSrc = new Rect(smokeWidth, smokeHeight, smokeWidth * 2, smokeHeight * 2);
                    break;
                case 6:
                    smokeSrc = new Rect(smokeWidth * 2, smokeHeight, smokeWidth * 3, smokeHeight * 2);
                    break;
                case 7:
                    smokeSrc = new Rect(0, smokeHeight * 2, smokeWidth, smokeHeight * 3);
                    break;
                case 8:
                    smokeSrc = new Rect(smokeWidth, smokeHeight * 2, smokeWidth * 2, smokeHeight * 3);
                    break;
                case 9:
                    smokeSrc = new Rect(smokeWidth * 2, smokeHeight * 2, smokeWidth * 3, smokeHeight * 3);
                    break;
                default:
                    break;
            }
            canvas.drawBitmap(smokeBitmap, smokeSrc, smokeDst, null);
            canvas.drawBitmap(burguerBitmap, burguerSrc, burguerDst, null);
        }
    }

    public boolean isTouched(float touchedX, float touchedY) {
        int x = 0;
        int y = 0;
        Bitmap bitmap = null;

        if (!isBurnt) {
            x = burguerX;
            y = burguerY;
            bitmap = burguerBitmap;
        } else {
            x = fireX;
            y = fireY;
            bitmap = fireBitmap;
        }
        if (touchedX >= x && touchedX <= x + bitmap.getWidth()
                && touchedY >= y && touchedY <= y + bitmap.getHeight()) {

            int localX = (int) (touchedX - x);
            int localY = (int) (touchedY - y);

            int pixel = bitmap.getPixel(localX, localY);
            return pixel != Color.TRANSPARENT;

        } else {
            return false;
        }
    }

    private void toggleState() {
        ExecutorService executor = Executors.newSingleThreadExecutor();

        executor.execute(() -> {
            try {
                for (int i = 0; i < cookingTime; i++) {
                    for (int j = 0; j < 5; j++) {
                        if (smokeSpriteNumber == 9) {
                            smokeSpriteNumber = 1;
                        } else {
                            smokeSpriteNumber++;
                        }
                        Thread.sleep(200);
                    }
                }
            }
            catch (InterruptedException e) {
                throw new RuntimeException(e);
            }

            isCooked = true;

            try {
                for (int i = 0; i < burningTime; i++) {
                    for (int j = 0; j < 5; j++) {
                        if (smokeSpriteNumber == 9) {
                            smokeSpriteNumber = 1;
                        } else {
                            smokeSpriteNumber++;
                        }
                        Thread.sleep(200);
                    }
                }
            }
            catch (InterruptedException e) {
                throw new RuntimeException(e);
            }

            isBurnt = true;

            try {
                while (true) {
                    if (fireSpriteNumber == 6) {
                        fireSpriteNumber = 1;
                    } else {
                        fireSpriteNumber++;
                    }
                    Thread.sleep(100);
                }
            }
            catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        });
    }
}
