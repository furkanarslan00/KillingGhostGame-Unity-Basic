using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

 public GameObject ghost;
 public GameObject laser;

   // Start is called before the first frame update
    void Start()
    {   

    }

    // Update is called once per frame
    void Update()
    {

       float h = Input.GetAxisRaw("Horizontal");
       Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
       rb.velocity = new Vector2(h*4, 0);

       ghostP();
       LaserP();
      
    }

    public void ghostP(){ 
       
        int frame = Time.frameCount;
        if(frame % 200== 0){
           int i = Random.Range(-5, 5);
           Instantiate(ghost, new Vector2(i,4), Quaternion.identity );
         }
    }


    public void LaserP(){         
       
       if(Input.GetButtonDown("Fire1") == true){
          Instantiate(laser, new Vector2((gameObject.transform.position.x),(gameObject.transform.position.y+2)), Quaternion.identity );
         }

    }

    public void OnTriggerEnter2D(Collider2D other){
             
       Time.timeScale = 0;
      
   }
    
}