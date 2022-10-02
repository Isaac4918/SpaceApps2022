using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{   
    public static CharacterStats instance;
    public List<string> disabledCardsList = new List<string>();

    public int points;
    public float health = 0;
    public int speed = 30;
    public int jump = 2700;
    public int hotResistance = 0;
    public int coldResistance = 0;
    public int RadResistance = 0;
    public int highGravityResistance = 0;
    public int lowGravityResistance = 0;
    public int highPreassureResistance = 0;
    public int lowPreassureResistance = 0;

    private void Awake()
    {
        if(CharacterStats.instance==null){
            CharacterStats.instance = this;
            DontDestroyOnLoad(this.gameObject);
        }else{
            Destroy(gameObject);
        }
    }

    public void heal(int livePoints){
        this.health += livePoints;
    }

    public void damage(int livePoints, string type){
        this.health -= livePoints;
    }

    public void effects(string type){
        
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
