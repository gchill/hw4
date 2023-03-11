using UnityEngine;
using UnityEngine.SceneManagement;

public class goal : MonoBehaviour
{
  void OnTriggerEnter2D()
  {
    Debug.Log("won");
    ScoreKeep.currentScore += 1;
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}
