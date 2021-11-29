using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdHaraket : MonoBehaviour
{

    public float speed;
    Rigidbody2D rbb;
    private Transform player;
    

    // Start is called before the first frame update
    void Start()
    {
      player = GameObject.FindGameObjectWithTag("Player").transform;
      rbb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        
            transform.position = Vector2.MoveTowards(this.transform.position,player.position,speed*Time.deltaTime);

        
    }
     void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            //Damage Player
            PlayerHareket player = other.transform.GetComponent<PlayerHareket>();
            if (player == null){
                Debug.LogError("Player is NULL");
            } else
            {
                player.Damage();
            }  
            Destroy(this.gameObject);
        } 
        else if (other.transform.tag == "Bullet")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        
    }

}