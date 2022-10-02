using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardStats : MonoBehaviour
{
    public GameObject Card;
    private int money = 10;
    public float radiation;
    public float cold;
    public float microgravity;
    public float hypergravity;

    public void stats()
    {
        if(Card.name == "Card")
        {
            money -= 2;
            Debug.Log(Card.name);
            Debug.Log(money);
        }

        if(Card.name == "Card (1)")
        {
            money -= 4;
            Debug.Log(Card.name);
            Debug.Log(money);
        }

        if(Card.name == "Card (2)")
        {
            money -= 5;
            Debug.Log(Card.name);
            Debug.Log(money);
        }

        if(Card.name == "Card (3)")
        {
            money -= 20;
            Debug.Log(Card.name);
            Debug.Log(money);
        }

        if(Card.name == "Card (4)")
        {
            money -= 10;
            Debug.Log(Card.name);
            Debug.Log(money);
        }

        if(Card.name == "Card (5)")
        {
            money -= 3;
            Debug.Log(Card.name);
            Debug.Log(money);
        }

        if(Card.name == "Card (6)")
        {
            money -= 4;
            Debug.Log(Card.name);
            Debug.Log(money);
        }

        if(Card.name == "Card (7)")
        {
            money -= 6;
            Debug.Log(Card.name);
            Debug.Log(money);
        }
    }
}
