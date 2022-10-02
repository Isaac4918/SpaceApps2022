using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{   
    public static CharacterStats instance;
    public int points = 10;
    public int health = 0;
    public int speed;
    public int jump;
    public int hotResistance = 0;
    public int coldResistance;
    public int RadResistance;
    public int highGravityResistance;
    public int lowGravityResistance;
    public int highPreassureResistance;
    public int lowPreassureResistance;

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

    // Update is called once per frame
    void Update()
    {
        
    }
}
