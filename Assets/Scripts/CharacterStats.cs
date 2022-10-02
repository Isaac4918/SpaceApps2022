using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{   
    public static CharacterStats instance;
    public List<string> disabledCardsList = new List<string>();

    public int points;
    public float health;
    public int speed;
    public int jump;
    public int hotResistance;
    public int coldResistance;
    public int RadResistance;
    public int highGravityResistance;
    public int lowGravityResistance;
    public int highPreassureResistance;
    public int lowPreassureResistance;

    private void Start() {
        this.points = 10;
        this.health = 100;
        this.speed = 30;
        this.jump = 2700;
        this.hotResistance = 0;
        this.coldResistance = 0;
        this.RadResistance = 0;
        this.highGravityResistance = 0;
        this.lowGravityResistance = 0;
        this.highPreassureResistance = 0;
        this.lowPreassureResistance = 0;
    }

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

    void Update()
    {
        
    }
}
