using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
     public float speed;
    public Rigidbody2D rb;
   int f;
    // Start is called before the first frame update
    void Start()
    {
          if(player.facingRight==true)
        {

rb.velocity = -transform.right * speed;
           
        }else
        {

            rb.velocity = transform.right * speed;
            

        }
    }

    // Update is called once per frame
    void Update()
    {
      
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Destroy(gameObject);
    }
}
