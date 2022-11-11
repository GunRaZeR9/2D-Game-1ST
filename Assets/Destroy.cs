using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{   
    
     void Start() {
     }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Platforms")){
            Destroy(other.gameObject);
        } 
        
    }

}