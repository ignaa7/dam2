package com.example.juegoandroid;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Toast;

import com.example.juegoandroid.dao.DbHelper;
import com.example.juegoandroid.databinding.ActivityScoreScreenBinding;
import com.example.juegoandroid.databinding.ActivityStoreScreenBinding;

import java.util.ArrayList;
import java.util.List;

public class StoreScreen extends AppCompatActivity {
    private ActivityStoreScreenBinding binding;
    private SharedPreferences upgradesPreferences;
    private DbHelper dbHelper;
    private int counter;
    private int price;
    private int grillsNumber;
    private int cookingTime;
    private String username;
    private int coins;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
                WindowManager.LayoutParams.FLAG_FULLSCREEN);

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_store_screen);

        binding = ActivityStoreScreenBinding.inflate(getLayoutInflater());
        View view = binding.getRoot();
        setContentView(view);

        dbHelper = new DbHelper(this);

        SharedPreferences currentUserPreferences = getSharedPreferences("currentUser", Context.MODE_PRIVATE);
        username = currentUserPreferences.getString("username", "");

        coins = dbHelper.getCoins(username);

        updateUpgrades();
    }

    private void updateUpgrades() {
        upgradesPreferences = getSharedPreferences("upgrades", Context.MODE_PRIVATE);
        counter = upgradesPreferences.getInt("counter", 15);
        price = upgradesPreferences.getInt("price", 5);
        grillsNumber = upgradesPreferences.getInt("grillsNumber", 2);
        cookingTime = upgradesPreferences.getInt("cookingTime", 4);

        List<String> upgrades = new ArrayList<>();
        upgrades.add("Tiempo de partida: " + counter + "s");
        upgrades.add("Precio de hamburguesa: " + price + " monedas");
        upgrades.add("Número de parrillas: " + grillsNumber + " parrillas");
        upgrades.add("Tiempo de cocción: " + cookingTime + "s");

        ArrayAdapter<String> adapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, upgrades);
        binding.lstUpgrades.setAdapter(adapter);

        binding.lstUpgrades.setOnItemClickListener((parent, view, position, id) -> {
            AlertDialog.Builder alertDialogBuilder;
            AlertDialog alertDialog;
            String message;

            switch (position) {
                case 0:
                    if (counter == 15) {
                        message = "15s -> 30s (Tienes " + coins + " monedas)";
                    } else {
                        message = "Nivel máximo alcanzado";
                    }
                    alertDialogBuilder = new AlertDialog.Builder(this);

                    alertDialogBuilder.setTitle("Tiempo de partida (Coste: 20 monedas)");
                    alertDialogBuilder.setMessage(message);

                    alertDialogBuilder.setPositiveButton("Comprar", (dialog, which) -> {
                        if (coins < 20) {
                            Toast.makeText(this, "Monedas insuficientes", Toast.LENGTH_SHORT).show();
                        } else if (message.equals("Nivel máximo alcanzado")) {
                            Toast.makeText(this, "Nivel máximo alcanzado", Toast.LENGTH_SHORT).show();
                        } else {
                            SharedPreferences.Editor editor = upgradesPreferences.edit();
                            editor.putInt("counter", 30);
                            editor.apply();

                            coins -= 20;

                            dbHelper.setCoins(username, coins);
                        }
                    });

                    alertDialogBuilder.setNegativeButton("Cancelar", (dialog, which) -> {

                    });

                    alertDialog = alertDialogBuilder.create();
                    alertDialog.show();
                    break;
                case 1:
                    if (price == 5) {
                        message = "5 monedas -> 10 monedas (Tienes " + coins + " monedas)";
                    } else {
                        message = "Nivel máximo alcanzado";
                    }
                    alertDialogBuilder = new AlertDialog.Builder(this);

                    alertDialogBuilder.setTitle("Precio de hamburguesa (Coste: 30 monedas)");
                    alertDialogBuilder.setMessage(message);

                    alertDialogBuilder.setPositiveButton("Comprar", (dialog, which) -> {
                        if (coins < 30) {
                            Toast.makeText(this, "Monedas insuficientes", Toast.LENGTH_SHORT).show();
                        } else if (message.equals("Nivel máximo alcanzado")) {
                            Toast.makeText(this, "Nivel máximo alcanzado", Toast.LENGTH_SHORT).show();
                        } else {
                            SharedPreferences.Editor editor = upgradesPreferences.edit();
                            editor.putInt("price", 10);
                            editor.apply();

                            coins -= 30;

                            dbHelper.setCoins(username, coins);
                        }
                    });

                    alertDialogBuilder.setNegativeButton("Cancelar", (dialog, which) -> {

                    });

                    alertDialog = alertDialogBuilder.create();
                    alertDialog.show();
                    break;
                case 2:
                    if (grillsNumber == 2) {
                        message = "2 parrillas -> 4 parrilas (Tienes " + coins + " monedas)";
                    } else {
                        message = "Nivel máximo alcanzado";
                    }
                    alertDialogBuilder = new AlertDialog.Builder(this);

                    alertDialogBuilder.setTitle("Número de parrillas (Coste: 40 monedas)");
                    alertDialogBuilder.setMessage(message);

                    alertDialogBuilder.setPositiveButton("Comprar", (dialog, which) -> {
                        if (coins < 40) {
                            Toast.makeText(this, "Monedas insuficientes", Toast.LENGTH_SHORT).show();
                        } else if (message.equals("Nivel máximo alcanzado")) {
                            Toast.makeText(this, "Nivel máximo alcanzado", Toast.LENGTH_SHORT).show();
                        } else {
                            SharedPreferences.Editor editor = upgradesPreferences.edit();
                            editor.putInt("grillsNumber", 4);
                            editor.apply();

                            coins -= 40;

                            dbHelper.setCoins(username, coins);
                        }
                    });

                    alertDialogBuilder.setNegativeButton("Cancelar", (dialog, which) -> {

                    });

                    alertDialog = alertDialogBuilder.create();
                    alertDialog.show();
                    break;
                case 3:
                    if (cookingTime == 4) {
                        message = "4s -> 2s (Tienes " + coins + " monedas)";
                    } else {
                        message = "Nivel máximo alcanzado";
                    }
                    alertDialogBuilder = new AlertDialog.Builder(this);

                    alertDialogBuilder.setTitle("Tiempo de cocción (Coste: 50 monedas)");
                    alertDialogBuilder.setMessage(message);

                    alertDialogBuilder.setPositiveButton("Comprar", (dialog, which) -> {
                        if (coins < 50) {
                            Toast.makeText(this, "Monedas insuficientes", Toast.LENGTH_SHORT).show();
                        } else if (message.equals("Nivel máximo alcanzado")) {
                            Toast.makeText(this, "Nivel máximo alcanzado", Toast.LENGTH_SHORT).show();
                        } else {
                            SharedPreferences.Editor editor = upgradesPreferences.edit();
                            editor.putInt("cookingTime", 2);
                            editor.apply();

                            coins -= 50;

                            dbHelper.setCoins(username, coins);
                        }
                    });

                    alertDialogBuilder.setNegativeButton("Cancelar", (dialog, which) -> {

                    });

                    alertDialog = alertDialogBuilder.create();
                    alertDialog.show();
                    break;
                default:
                    break;
            }

            updateUpgrades();
        });
    }

    public void goBack(View view) {
        finish();
    }
}