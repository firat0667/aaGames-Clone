using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinScript : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    private bool isPinned = false;
   

    private void Update()
    {
        if(!isPinned)
        rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Rotator")
        {

            transform.SetParent(collision.transform);
           
            ScoreScript.PinCount++;
            
            isPinned = true;
        }
        else if (collision.tag == "Pin")
        {
            FindObjectOfType<Gamemanager>().EndGame();
        }
    }
}

