using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    public float speed;
    [SerializeField]
    private float jumpforce;
    public float Move;
    [SerializeField]
    Rigidbody2D rb;

    private bool facingRight;
    private bool onGround;

    void Start () {
 
        
 }
 

 void Update () {
     Move = Input.GetAxis("Horizontal");
     rb.velocity = new Vector2(speed * Move , rb.velocity.y);

     if(Input.GetButtonDown("Jump") && onGround){

        rb.velocity = new Vector2(rb.velocity.x,jumpforce);
     }
        if(facingRight == false && Move > 0 ){
            Flip();
        }else if(facingRight == true && Move < 0 ){
            Flip();
        }
        void Flip(){
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;  
    }
 }

private void OnCollisionEnter2D(Collision2D colision) {
    if(colision.gameObject.CompareTag("Platforms")){
        onGround = true;
    }
 }
private void OnCollisionExit2D(Collision2D colision) {
    if(colision.gameObject.CompareTag("Platforms")){
        onGround = false;
    }
 }

}




    

