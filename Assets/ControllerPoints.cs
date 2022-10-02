using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPoints : MonoBehaviour
{
    public static ControllerPoints instance;
    [SerializeField] private int pointsCounter;

    private void Awake() {
        if(ControllerPoints.instance == null){
            ControllerPoints.instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }

    public void sumPoints(int points){
        pointsCounter += points;
    }
}
