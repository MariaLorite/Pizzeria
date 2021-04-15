using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomPizza : MonoBehaviour
{
    public List<string> ingredientesName;
    Menu menu;
   // Ingredient extraIngredient;

    private void Awake()
    {
        menu = FindObjectOfType<Menu>();
    }

    void Start()
    {
        //extraIngredient = new Ingredient();
    }

    public void PutIngredients()
    {
        if (ingredientesName.Count != 0)
        {
            for (int i = 0; i < ingredientesName.Count; i++)
            {
                // extraIngredient.IngredientName = ingredientesName[i];

                var _ingredient = new Ingredient();
                _ingredient.IngredientName = ingredientesName[i];
                menu.Pizza.ingredients.Add(_ingredient);
                Debug.Log("For Custom Pizza : " + _ingredient.IngredientName);
            }
        }
        else
        {
            Debug.Log("Has pedido una pizza Margarita");
        }
    }
}
