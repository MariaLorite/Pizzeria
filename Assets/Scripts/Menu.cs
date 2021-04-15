using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public Pizza Pizza;
    OrderController gameController;
    CustomPizza customPizza;
    List<Ingredient> extraIngredientCustom;

    private void Awake()
    {
        gameController = FindObjectOfType<OrderController>();
        customPizza = FindObjectOfType<CustomPizza>();
    }

    private void Start()
    {
       
        extraIngredientCustom = new List<Ingredient>();
    }

    public void MakePizza4Quesos()
    {
        Pizza = new Pizza();

        Ingredient Mozzarella = new Ingredient();
        Mozzarella.IngredientName = "Mozzarella";
        Pizza.ingredients.Add(Mozzarella);

        Ingredient Parmesano = new Ingredient();
        Parmesano.IngredientName = "Parmesano";
        Pizza.ingredients.Add(Parmesano);

        Ingredient Ricotta = new Ingredient();
        Ricotta.IngredientName = "Ricotta";
        Pizza.ingredients.Add(Ricotta);

        Ingredient Gorgonzola = new Ingredient();
        Gorgonzola.IngredientName = "Gorgonzola";
        Pizza.ingredients.Add(Gorgonzola);

        Pizza.precio = 8.5f;

        gameController.ChoosePizza(Pizza);
        Debug.Log("He añadido una pizza 4Quesos");

        Pizza = null;
    }

    public void MakePizzaBarbacoa()
    {

        Pizza = new Pizza();

        Ingredient Pollo = new Ingredient();
        Pollo.IngredientName = "Pollo";
        Pizza.ingredients.Add(Pollo);

        Ingredient CarnePicada = new Ingredient();
        CarnePicada.IngredientName = "CarnePicada";
        Pizza.ingredients.Add(CarnePicada);

        Ingredient Cebolla = new Ingredient();
        Cebolla.IngredientName = "Cebolla";
        Pizza.ingredients.Add(Cebolla);

        Ingredient Picante = new Ingredient();
        Picante.IngredientName = "Picante";
        Pizza.ingredients.Add(Picante);

        Pizza.precio = 8.5f;

        gameController.ChoosePizza(Pizza);
        Debug.Log("He añadido una pizza Barbacoa");

        Pizza = null;
    }

    public void MakePizzaJamon()
    {
        Pizza = new Pizza();

        Ingredient Jamon = new Ingredient();
        Jamon.IngredientName = "Jamon";
        Pizza.ingredients.Add(Jamon);

        Ingredient Oregano = new Ingredient();
        Oregano.IngredientName = "Oregano";
        Pizza.ingredients.Add(Oregano);

        Pizza.precio = 6f;

        gameController.ChoosePizza(Pizza);
        Debug.Log("He añadido una pizza Jamon");

        Pizza = null;

    }

    public void MakePizzaHawaiana()
    {
        Pizza = new Pizza();

        Ingredient Piña = new Ingredient();
        Piña.IngredientName = "Piña";
        Pizza.ingredients.Add(Piña);

        Ingredient Jamon = new Ingredient();
        Jamon.IngredientName = "Jamon";
        Pizza.ingredients.Add(Jamon);

        Ingredient Champiñones = new Ingredient();
        Champiñones.IngredientName = "Champiñones";
        Pizza.ingredients.Add(Champiñones);

        Ingredient Mozzarella = new Ingredient();
        Mozzarella.IngredientName = "Mozzarella";
        Pizza.ingredients.Add(Mozzarella);

        Pizza.precio = 7.5f;

        gameController.ChoosePizza(Pizza);
        Debug.Log("He añadido una pizza Hawaiana");

        Pizza = null;
    }

    public void MakePizzaCustom()
    {
        Pizza = new Pizza();

        customPizza.PutIngredients();

        Pizza.precio = 7.5f;

        string ingredientString = "";

        for (int i = 0; i < Pizza.ingredients.Count; i++)
        {
            ingredientString = ingredientString + " " + Pizza.ingredients[i].IngredientName;
            Debug.Log(Pizza.ingredients[i].IngredientName);
        }

        //foreach (var item in Pizza.ingredients)
        //{
        //    print(item.IngredientName);
        //}

        gameController.ChoosePizza(Pizza);
        Debug.Log("He añadido una pizza Custom");
        Debug.Log("Ingredientes" + ingredientString);

        Pizza = null;
    }

}
