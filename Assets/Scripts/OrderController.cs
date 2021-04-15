using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderController : MonoBehaviour
{
    List<Pizza> pizzas;
    float totalPrice = 0;

    // Start is called before the first frame update
    void Start()
    {
        pizzas = new List<Pizza>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pizzas != null)
        {
            Debug.Log(pizzas.Count);
            Debug.Log("Precio Total = " + totalPrice);
        }
    }

    public void ChoosePizza(Pizza nuevaPizza)
    {
        pizzas.Add(nuevaPizza);
        totalPrice = TotalPrice();
    }

    public float TotalPrice()
    {
        for (int i = 0; i < pizzas.Count; i++)
        {
            totalPrice = totalPrice + pizzas[i].precio;
        }
        return totalPrice;
    }
}
