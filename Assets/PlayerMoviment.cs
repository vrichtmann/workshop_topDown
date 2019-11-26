using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public float moveSpeed = 0.5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 moviment;

    void Update(){
       
        moviment.x = Input.GetAxis("Horizontal");
        moviment.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate() {

        Debug.Log("moviment.x " + moviment.x);
        //Debug.Log("moviment.y " + moviment.y);
        //Debug.Log("moviment.sqrMagnitude : " + moviment.sqrMagnitude);
        this.transform.position = new Vector3(this.transform.position.x + (moviment.x * moveSpeed), this.transform.position.y + (moviment.y * moveSpeed), this.transform.position.z);

      
        this.GetComponent<SpriteRenderer>().flipX = (moviment.x < 0);
       
        animator.SetFloat("Horizontal", moviment.x);
        animator.SetFloat("Vertical", moviment.y);
        animator.SetFloat("Speed", moviment.sqrMagnitude);
        //rb.AddForce(new Vector2(moviment.x, moviment.y));
        //rb.MovePosition(rb.position * moviment * moveSpeed * Time.fixedDeltaTime);
    }
}
