using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBottom : MonoBehaviour
{
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other ) 
        
     {
        if(other.CompareTag("Player")){
            Destroy(other.gameObject);
        }
    }
}
