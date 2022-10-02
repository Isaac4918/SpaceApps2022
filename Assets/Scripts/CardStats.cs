using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardStats : MonoBehaviour
{
    public GameObject Card;
    public Button thisCard;

    private void FixedUpdate() {
        thisCard = GetComponent<Button>();

        for(int i = 0; i < CharacterStats.instance.disabledCardsList.Count; i++){
            if(Card.name == CharacterStats.instance.disabledCardsList[i]){
                thisCard.interactable = false;
            }
        }
    }

    public void stats()
    {

        if(Card.name == "Card")
        {
            sumarCarta(12,10,16,7,8,4,2,1);
        }

        if(Card.name == "Card (1)")
        {
            Debug.Log(Card.name);
            sumarCarta(12,10,16,7,8,4,2,1);
        }

        if(Card.name == "Card (2)")
        {
            Debug.Log(Card.name);
            sumarCarta(12,10,16,7,8,4,2,1);
        }

        if(Card.name == "Card (3)")
        {
            Debug.Log(Card.name);
            sumarCarta(12,10,16,7,8,4,2,1);
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

            Debug.Log(Card.name);
            sumarCarta(5,10,16,7,8,4,2,1);
        }

        if(Card.name == "Card (5)")
        {
            Debug.Log(Card.name);
            sumarCarta(12,10,16,7,8,4,2,1);
        }

        if(Card.name == "Card (6)")
        {
            Debug.Log(Card.name);
            sumarCarta(12,10,16,7,8,4,2,1);
        }

        if(Card.name == "Card (7)")
        {
            Debug.Log(Card.name);
            sumarCarta(12,10,16,7,8,4,2,1);
        }

        string lol = "";
        for(int i = 0; i < CharacterStats.instance.disabledCardsList.Count; i++){
            lol += CharacterStats.instance.disabledCardsList[i]+",,,";
        }
        Debug.Log(lol);
    }

    private void sumarCarta(int cost, int hot, int cold, int rad, int highGrav, int lowGrav, int highPre, int lowPre){
        if(CharacterStats.instance.points >= cost)
        {
            //thisCard.interactable = false;
            CharacterStats.instance.points -= cost;
            CharacterStats.instance.hotResistance += hot;
            CharacterStats.instance.coldResistance += cold;
            CharacterStats.instance.RadResistance += rad;
            CharacterStats.instance.highGravityResistance += highGrav;
            CharacterStats.instance.lowGravityResistance += lowGrav;
            CharacterStats.instance.highPreassureResistance += highPre;
            CharacterStats.instance.lowPreassureResistance += lowPre;

            CharacterStats.instance.disabledCardsList.Add(Card.name);
        }
        else{
            Debug.Log("No se compra");
        }
        
    }
}
