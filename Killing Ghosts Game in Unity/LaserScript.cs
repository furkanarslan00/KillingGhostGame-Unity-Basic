using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
       Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
       rb.velocity = new Vector2(0,4);
    }

    // Update is called once per frame
    void Update()
    {
          
    }

     public void OnTriggerEnter2D(Collider2D other){         
      Destroy(gameObject);      
   }

   
}
