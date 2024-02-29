package com.example.juegoandroid.dao;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import com.example.juegoandroid.models.User;

import java.util.ArrayList;
import java.util.List;

public class DbHelper extends SQLiteOpenHelper {
    private static final String DATABASE_NAME = "cooking_game.db";
    private static final int DATABASE_VERSION = 1;

    public DbHelper(Context context) {
        super(context, DATABASE_NAME, null, DATABASE_VERSION);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        String createUsersQuery = "CREATE TABLE IF NOT EXISTS users ("
                + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
                + "username TEXT, "
                + "coins INTEGER, "
                + "score INTEGER)";
        db.execSQL(createUsersQuery);
    }

    @Override
    public void onUpgrade(SQLiteDatabase sqLiteDatabase, int i, int i1) {

    }

    public List<User> getUsers() {
        List<User> users = new ArrayList<>();

        SQLiteDatabase db = this.getReadableDatabase();
        Cursor cursor = db.query("users", null, null, null, null, null, null);

        while (cursor.moveToNext()) {
            String username = cursor.getString(cursor.getColumnIndexOrThrow("username"));
            int score = cursor.getInt(cursor.getColumnIndexOrThrow("score"));

            users.add(new User(username, score));
        }

        return users;
    }

    public int getCoins(String username) {
        SQLiteDatabase db = this.getReadableDatabase();

        String query = "SELECT coins FROM users WHERE username = ?";

        String[] selectionArgs = {username};

        Cursor cursor = db.rawQuery(query, selectionArgs);

        if (cursor.moveToFirst()) {
            return cursor.getInt(cursor.getColumnIndexOrThrow("coins"));
        } else {
            return 0;
        }
    }

    public synchronized boolean checkUser(String username) {
        SQLiteDatabase db = this.getReadableDatabase();

        String query = "SELECT username FROM users WHERE username = ?";

        String[] selectionArgs = {username};

        Cursor cursor = db.rawQuery(query, selectionArgs);

        if (cursor.moveToFirst()) {
            return true;
        } else {
            addUser(username);
            return false;
        }
    }

    private void addUser(String username) {
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues values = new ContentValues();
        values.put("username", username);
        values.put("score", 0);
        values.put("coins", 0);

        db.insert("users", null, values);
    }

    public boolean checkScore(String username, int newScore) {
        SQLiteDatabase db = this.getReadableDatabase();

        String query = "SELECT score, coins FROM users WHERE username = ?";

        String[] selectionArgs = {username};

        Cursor cursor = db.rawQuery(query, selectionArgs);

        boolean isBestScore = false;

        if (cursor.moveToFirst()) {
            int score = cursor.getInt(cursor.getColumnIndexOrThrow("score"));
            int coins = cursor.getInt(cursor.getColumnIndexOrThrow("coins"));

            if (newScore > score) {
                isBestScore = true;
                updateScore(username, newScore);
            }

            updateCoins(username, coins, newScore);
        }

        return isBestScore;
    }

    private void updateScore(String username, int newScore) {
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues values = new ContentValues();
        values.put("score", newScore);
        db.update("users", values, "username = ?", new String[]{username});
    }

    private void updateCoins(String username, int coins, int earnedCoins) {
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues values = new ContentValues();
        values.put("coins", coins + earnedCoins);
        db.update("users", values, "username = ?", new String[]{username});
    }

    public void setCoins(String username, int coins) {
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues values = new ContentValues();
        values.put("coins", coins);
        db.update("users", values, "username = ?", new String[]{username});
    }
}
