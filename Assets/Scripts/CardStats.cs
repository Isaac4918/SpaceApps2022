using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardStats : MonoBehaviour
{
    public GameObject Card;
    // private int money = 10;
    // public float radiation;
    // public float cold;
    // public float microgravity;
    // public float hypergravity;

    public void stats()
    {
        if(Card.name == "Card")
        {
            money -= 2;
            Debug.Log(Card.name);
            Debug.Log(money);
            //sumarCarta(1,6,7,8,4,2,1);

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
        /*
            Thermococcus gammatolerans
            +7 rad
            +3 high temp
            -2 low temp
            -1 highpreassure
            0 low preassure
            0 gravity
            0 gravity

        */

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

    public void sumarCarta(int cost, int hot, int cold, int rad, int highGrav, int lowGrav, int highPre, int lowPre){
        CharacterStats.instance.hotResistance += hot;
        int coldResistance;
        int RadResistance;
        int highGravityResistance;
        int lowGravityResistance;
        int highPreassureResistance;
        int lowPreassureResistance;
    }
}
