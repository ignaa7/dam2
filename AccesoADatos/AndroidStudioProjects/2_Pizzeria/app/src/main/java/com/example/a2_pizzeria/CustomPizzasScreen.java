package com.example.a2_pizzeria;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;

import com.example.a2_pizzeria.databinding.ActivityCustomPizzasScreenBinding;
import com.example.a2_pizzeria.databinding.ActivityOrderScreenBinding;
import com.example.a2_pizzeria.model.Ingredient;

import java.util.ArrayList;
import java.util.Set;

public class CustomPizzasScreen extends AppCompatActivity {

    private ActivityCustomPizzasScreenBinding binding;

    private ArrayList<Ingredient> ingredients = new ArrayList<>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_custom_pizzas_screen);

        binding = ActivityCustomPizzasScreenBinding.inflate(getLayoutInflater());
        View view = binding.getRoot();
        setContentView(view);

        ingredients.add(new Ingredient("Queso", 2));
        ingredients.add(new Ingredient("Pepperoni", 6));
        ingredients.add(new Ingredient("Piña", 3));
        ingredients.add(new Ingredient("Pollo", 5.5f));
        ingredients.add(new Ingredient("Salchichas", 6.5f));
        ingredients.add(new Ingredient("Aceitunas", 3.5f));

        SharedPreferences favoritePizzaPreferences = getSharedPreferences("favoritePizza", Context.MODE_PRIVATE);

        if (!favoritePizzaPreferences.getAll().isEmpty()) {
            String size = favoritePizzaPreferences.getString("size", "");
            Set<String> ingredients = favoritePizzaPreferences.getStringSet("ingredients", null);

            
        }
    }

    public void selectIngredient(View view) {

    }
}