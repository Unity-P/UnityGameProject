using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHareket : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 velocity;

    float speedAmount = 5f;
    float jumpAmount = 5f;
    private int _lives = 3;
    public GameObject gameOverText;
    // Start is called before the first frame update
    void Start()
    {
        gameOverText.SetActive (false);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        velocity = new Vector3 (Input.GetAxis("Horizontal"), 0f);
        transform.position += velocity * speedAmount * Time.deltaTime;
        

        if (Input.GetButtonDown("Jump") && Mathf.Approximately(rb.velocity.y, 0))
        {
            rb.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
        }
        /*if(Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.rotation = Quaternion.Euler(0f ,180f, 0f);
        }
        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        } */
    }
    public void Damage()
    {
        _lives--;

        if (_lives < 1)
        {
            /* if (SpawnBird == null)
            {
             Debug.LogError("Spawn Manager is NULL");
            } else
            {
                SpawnBird.OnPlayerDeath();
            } */
        
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag.Equals("Enemy"))
        {
            gameOverText.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
