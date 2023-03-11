using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class frog : MonoBehaviour
{
    public Rigidbody2D rb;
    public AudioSource frogsound;
    
    void Start()
    {
      frogsound = GetComponent<AudioSource>();
    }

    void Update()
    {
    if(Input.GetKeyDown(KeyCode.RightArrow))
         rb.MovePosition(rb.position + Vector2.right);
    else if(Input.GetKeyDown(KeyCode.LeftArrow))
         rb.MovePosition(rb.position + Vector2.left);
    else if(Input.GetKeyDown(KeyCode.DownArrow))
          rb.MovePosition(rb.position + Vector2.down);
    else if(Input.GetKeyDown(KeyCode.UpArrow))
          rb.MovePosition(rb.position + Vector2.up);
    }
    void OnTriggerEnter2D (Collider2D col)
    {
      if( col.tag == "Car")
      {
            frogsound.Play();
            ScoreKeep.currentScore = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      }
    }
}
