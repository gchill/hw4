using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.IO;
using UnityEditor;
using System.IO;

public class highscores : MonoBehaviour
{
    public Text Highscores;
    public  static TextAsset highScores;
    public string name;
    public int score;
    public GameObject quitbtn;


    public void Start()
    {
        string path = "Assets/highscores.txt";
        string line = "";
        Highscores.text = "";
        string[] readtext = File.ReadAllLines(path);
        foreach(string s in readtext)
        {
            Highscores.text += s + "\n";
        }
    }
    public void writeScore()
    {
         if(ScoreKeep.currentScore > 10)
        {
            string path = "Assets/highscores.txt";
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(KeepData.Name + ScoreKeep.currentScore);
            writer.Close();
        }
    }
}
