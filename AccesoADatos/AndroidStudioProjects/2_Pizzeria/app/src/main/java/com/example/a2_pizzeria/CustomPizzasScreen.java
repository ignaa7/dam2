package com.example.a2_pizzeria;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.CheckBox;
import android.widget.RadioButton;
import android.widget.Toast;

import com.example.a2_pizzeria.databinding.ActivityCustomPizzasScreenBinding;
import com.example.a2_pizzeria.databinding.ActivityOrderScreenBinding;
import com.example.a2_pizzeria.model.Ingredient;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.Set;

public class CustomPizzasScreen extends AppCompatActivity {

    private ActivityCustomPizzasScreenBinding binding;

    private ArrayList<Ingredient> ingredients = new ArrayList<>();
    private ArrayList<Ingredient> selectedIngredients = new ArrayList<>();

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

        SharedPreferences favoritePizzaPreferences = getSharedPreferences("customPizzaOrder", Context.MODE_PRIVATE);
        SharedPreferences showFavoritePizzaPreferences = getSharedPreferences("favorite", Context.MODE_PRIVATE);

        boolean showFavorite = showFavoritePizzaPreferences.getBoolean("showFavorite", false);

        if (showFavorite) {
            String size = favoritePizzaPreferences.getString("size", "");
            ArrayList<String> ingredients = new ArrayList<>(favoritePizzaPreferences.getStringSet("ingredients", null));

            if (size.equals("Pequeña")) {
                binding.rbSmall.setChecked(true);
            }
            else if (size.equals("Mediana")) {
                binding.rbMedium.setChecked(true);
            }
            else if (size.equals("Grande")) {
                binding.rbBig.setChecked(true);
            }

            for (String ingredient : ingredients) {
                if (ingredient.equals("Queso")) {
                    binding.cbCheese.setChecked(true);
                }
                else if (ingredient.equals("Pepperoni")) {
                    binding.cbPepperoni.setChecked(true);
                }
                else if (ingredient.equals("Piña")) {
                    binding.cbPineapple.setChecked(true);
                }
                else if (ingredient.equals("Pollo")) {
                    binding.cbChicken.setChecked(true);
                }
                else if (ingredient.equals("Salchichas")) {
                    binding.cbSausages.setChecked(true);
                }
                else if (ingredient.equals("Aceitunas")) {
                    binding.cbOlives.setChecked(true);
                }
            }
        }




    }

    @Override
    protected void onResume() {
        super.onResume();
        MainActivity.setScreenBackgroundColor(binding.getRoot());
    }

    public void selectIngredient(View view) {
        String ingredientName = ((CheckBox)view).getText().toString();

        Ingredient ingredient = ingredients.stream()
                .filter(obj -> obj.getName().equals(ingredientName))
                .findFirst()
                .orElse(null);

        if (ingredient != null) {
            if (((CheckBox)view).isChecked()) {
                if (selectedIngredients.size() < 3) {
                    selectedIngredients.add(ingredient);
                }
                else {
                    Toast.makeText(this, "No puede seleccionar más de 3 ingredientes", Toast.LENGTH_SHORT).show();
                    ((CheckBox)view).setChecked(false);
                }
            }
            else {
                if (selectedIngredients.size() > 0) {
                    selectedIngredients.remove(ingredient);
                }
            }
        }
    }

    public void confirm(View view) {
        int idSelectedSize = binding.rgSizes.getCheckedRadioButtonId();

        if (idSelectedSize == -1 || selectedIngredients.size() != 3) {
            Toast.makeText(this, "Seleccione un tamaño y 3 ingredientes", Toast.LENGTH_SHORT).show();
        }
        else {
            String sizeText = ((RadioButton)findViewById(idSelectedSize)).getText().toString();
            int size = 0;
            float price = 0;

            if (sizeText.equals("Pequeña")) size = 0;
            else if (sizeText.equals("Mediana")) size = 1;
            else size = 2;

            SharedPreferences customPizzaOrderPreferences = getSharedPreferences("customPizzaOrder", Context.MODE_PRIVATE);
            SharedPreferences.Editor editor = customPizzaOrderPreferences.edit();

            ArrayList<String> selectedIngredientsNames = new ArrayList<>();
            for (Ingredient ingredient : selectedIngredients) {
                selectedIngredientsNames.add(ingredient.getName());
                price += ingredient.getPrice();
            }

            editor.putStringSet("ingredients", new HashSet<>(selectedIngredientsNames));
            editor.putString("size", sizeText);
            editor.putFloat("price", price);
            editor.apply();

            startActivity(new Intent(this, CustomConfirmationScreen.class));
        }
    }

    public void cancel(View view) {
        finish();
    }
}