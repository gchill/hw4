using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pauseGame : MonoBehaviour
{
    public GameObject carspawn;
    public Text pausetext;
    public GameObject frog;
   public void Start()
   {
    pausetext.enabled =false;
   }
   public void Update()
   {
    if(Input.GetKeyDown(KeyCode.Escape))
    {
        pausetext.enabled =false;
        carspawn.SetActive(true);
        frog.SetActive(true);
    }
   }
   public void pause()
   {
    carspawn.SetActive(false);
    pausetext.enabled = true;
    frog.SetActive(false);
   }
}
