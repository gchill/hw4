using UnityEngine;
using UnityEngine.UI;

public class ScoreKeep : MonoBehaviour
{
    public static int currentScore = 0;
    public Text scoretext;

    void Start()
    {
        scoretext.text = currentScore.ToString();
    }
}
