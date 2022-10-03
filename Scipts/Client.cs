using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    Piz currentPiz;
    public ScriptableObject pizzaValues;
    public Text txt;
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            Piz pizza = new BasicPiz();
            currentPiz = pizza;
            txt.text = "With Basic pizza" + '\n' + "Price: " + currentPiz.GetPrice().ToString() + '\n' + "Energy: " + currentPiz.GetEnergy().ToString();

            Debug.Log("Price: " + currentPiz.GetPrice());
            Debug.Log("Energy: " + currentPiz.GetEnergy());
        }

        if (Input.GetKeyDown("2"))
        {
            Piz pizza = new BasicPiz();
            pizza = new WithExtraCheese(pizza);
            currentPiz = pizza;

            txt.text = "With Extra Cheese" + '\n' + "Price: " + currentPiz.GetPrice().ToString() + '\n' + "Energy: " + currentPiz.GetEnergy().ToString();
            Debug.Log("Price: " + currentPiz.GetPrice());
            Debug.Log("Energy: " + currentPiz.GetEnergy());
        }

        if (Input.GetKeyDown("3"))
        {
            Piz pizza = new BasicPiz();
            pizza = new WithTomato(pizza);
            currentPiz = pizza;

            txt.text = "With Tomato" + '\n' + "Price: " + currentPiz.GetPrice().ToString() + '\n' + "Energy: " + currentPiz.GetEnergy().ToString();
            Debug.Log("Price: " + currentPiz.GetPrice());
            Debug.Log("Energy: " + currentPiz.GetEnergy());
        }

        if (Input.GetKeyDown("4"))
        {
            Piz pizza = new BasicPiz();
            pizza = new WithPeperoni(pizza);
            currentPiz = pizza;
            txt.text = "With Peperoni" + '\n' + "Price: " + currentPiz.GetPrice().ToString() + '\n' + "Energy: " + currentPiz.GetEnergy().ToString();

            Debug.Log("Price: " + currentPiz.GetPrice());
            Debug.Log("Energy: " + currentPiz.GetEnergy());
        }

        if (Input.GetKeyDown("5"))
        {
            Piz pizza = new BasicPiz();
            pizza = new WithChicken(pizza);
            currentPiz = pizza;

            txt.text = "With Chicken" + '\n' + "Price: " + currentPiz.GetPrice().ToString() + '\n' + "Energy: " + currentPiz.GetEnergy().ToString();
            Debug.Log("Price: " + pizza.GetPrice());
            Debug.Log("Energy: " + currentPiz.GetEnergy());
        }
        if (Input.GetKeyDown("6"))
        {
            Piz pizza = new BasicPiz();
            pizza = new WithAllIn(new WithChicken(new WithPeperoni(new WithTomato(new WithExtraCheese(pizza)))));
            currentPiz = pizza;

            txt.text = "With Chicken, Peperoni, Tomato, Extra cheese" + '\n' +  "Price: " + currentPiz.GetPrice().ToString() + '\n' + "Energy: " + currentPiz.GetEnergy().ToString();
            Debug.Log("Price: " + currentPiz.GetPrice());
            Debug.Log("Energy: " + currentPiz.GetEnergy());
        }

        if (Input.GetKeyDown("d"))
        {
            Piz pizza = new BasicPiz();
            currentPiz = pizza;

            txt.text = "Price:" + '\n' + "Energy:";

        }
    }
}
