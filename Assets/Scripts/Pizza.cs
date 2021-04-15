using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza 
{
    public List<Ingredient> ingredients;
    public int size;
    public int bakingTime;
    public float precio;
    public int totalIngredient;

    public Pizza()
    {
        ingredients = new List<Ingredient>();
        MakeBasePizza();
        totalIngredient = ingredients.Count;
    }

    public void MakeBasePizza()
    {
        Ingredient Masa = new Ingredient();
        Masa.IngredientName = "Masa";
        ingredients.Add(Masa);

        Ingredient Tomate = new Ingredient();
        Tomate.IngredientName = "Tomate";
        ingredients.Add(Tomate);

        Ingredient AOVE = new Ingredient();
        AOVE.IngredientName = "AOVE";
        ingredients.Add(AOVE);
    }
}
