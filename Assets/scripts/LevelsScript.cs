using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsScript : MonoBehaviour
{
    public void OpenLevel1()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
    }
         public void Home()
    {
        SceneManager.LoadScene("Mainmenu"); // EXACT name
    }
      public void OpenLevel2()
    {
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1f;
    }
}
