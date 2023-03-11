using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    public GameObject frog;
    public AudioSource frogsound;
void OnTriggerEnter2D (Collider2D col)
{
    if( col.tag == "Car")
    {
        frogsound.Play();
    }
}    
}
