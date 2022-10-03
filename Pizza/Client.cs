using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    Piz currentPiz;

    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            Piz pizza = new BasicPiz();
            currentPiz = pizza;
            Debug.Log("Price: " + pizza.GetPrice());
            Debug.Log("Energy: " + pizza.GetEnergy());
        }

        if (Input.GetKeyDown("3"))
        {
            Piz pizza = new BasicPiz();
            pizza = new WithExtraCheese(pizza);
            currentPiz = pizza;
            Debug.Log("Price: " + pizza.GetPrice());
            Debug.Log("Energy: " + pizza.GetEnergy());
        }

        if (Input.GetKeyDown("4"))
        {
            Piz pizza = new BasicPiz();
            pizza = new WithTomato(pizza);
            currentPiz = pizza;
            Debug.Log("Price: " + pizza.GetPrice());
            Debug.Log("Energy: " + pizza.GetEnergy());
        }

        if (Input.GetKeyDown("5"))
        {
            Piz pizza = new BasicPiz();
            pizza = new WithPeperoni(pizza);
            currentPiz = pizza;
            Debug.Log("Price: " + pizza.GetPrice());
            Debug.Log("Energy: " + pizza.GetEnergy());
        }

        if (Input.GetKeyDown("6"))
        {
            Piz pizza = new BasicPiz();
            pizza = new WithChicken(pizza);
            currentPiz = pizza;
            Debug.Log("Price: " + pizza.GetPrice());
            Debug.Log("Energy: " + pizza.GetEnergy());
        }

        if (Input.GetKeyDown("d"))
        {
            if (currentPiz != null)
            {
                //GameObject.Destroy(currentPiz.GetGameObject());
                currentPiz = null;
            }
        }
    }
}
