using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class SceneStart : MonoBehaviour
{
  public  static Text pausetext;
   public void start()
   {
    pausetext.enabled =false;
   }
  public void StartGame()
   {
    SceneManager.LoadScene("main");
   }
   public void QuitGame()
   {
    SceneManager.LoadScene("end");
   }
   public void End()
   {
    Application.Quit();
   }
}
