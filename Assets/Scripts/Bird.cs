using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float force;
    Rigidbody2D birdRigid;
    BoxCollider2D birdCollider;
    public GameObject restartButton;
    void Start()
    {
        Time.timeScale = 0;
        birdRigid = GetComponent<Rigidbody2D>();
        birdCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1;
            birdRigid.velocity = Vector2.up * force;
        }
    }

 


   private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Time.timeScale = 0;
            Destroy(gameObject);
            restartButton.SetActive(true);
        }
    }
}
