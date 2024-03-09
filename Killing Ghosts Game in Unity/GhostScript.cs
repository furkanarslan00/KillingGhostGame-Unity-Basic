using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostScript : MonoBehaviour
{

  public static int ctr = 0;

    // Start is called before the first frame update
    void Start()
    {
      Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
       rb.velocity = new Vector2(4,-2);  
    }
    

    // Update is called once per frame
    void Update()
    {  
      Debug.Log("You killed " + ctr + " ghosts."); 
      Exit();
    }

    public void OnTriggerEnter2D(Collider2D other){
          
      Destroy(gameObject);
      ctr++;
        
    }

    public void Exit(){

      if(gameObject.transform.position.y < -6){         
        Time.timeScale = 0;
      }

    }









}