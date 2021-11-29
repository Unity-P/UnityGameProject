using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBird : MonoBehaviour {

    public GameObject Bird;
    float randY;
    float randX;
    Vector2 whereToSpawn;
    public float SpawnRate = 1f;
    float nextSpawn = 0.0f;


    // Start is called before the first frame update
    void Start (){
        
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + SpawnRate;
            randY = Random.Range (2.0f,4.7f);
            randX = Random.Range (-8.75f,8.75f);
            //whereToSpawn = new Vector2 (transform.position.x, randY);
            whereToSpawn = new Vector2 (randX,randY);
            Instantiate (Bird, whereToSpawn, Quaternion.identity);

        }
    }
  
}
