using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepData : MonoBehaviour
{
    public static string Name;
    public static int playerscore;
    public static float carSpeed;
    public static float carDelay;

    public InputField NameIn;
    public Slider speedSlider;
    public Slider delaySlider;
    public Text carSpeedtxt;
    public Text delaytxt;

   public void playerName()
    {
        Name = NameIn.text;
        
    }
    public void sliders()
    {
        carSpeed = speedSlider.value;
        carDelay = delaySlider.value;
        carSpeedtxt.text = carSpeed.ToString();
        delaytxt.text = carDelay.ToString();
    }
}
