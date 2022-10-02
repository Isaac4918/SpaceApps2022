using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADNPoints : MonoBehaviour
{
    [SerializeField] private GameObject effect;
    [SerializeField] private int pointsCounter;

    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            ControllerPoints.instance.sumPoints(pointsCounter);
            Instantiate(effect,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
