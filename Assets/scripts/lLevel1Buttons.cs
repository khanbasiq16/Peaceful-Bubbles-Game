using UnityEngine;
using UnityEngine.SceneManagement;


public class lLevel1Buttons : MonoBehaviour
{
        public void Retry()
    {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
     public void Home()
    {
        SceneManager.LoadScene("Mainmenu"); // EXACT name
    }
     public void Levels()
    {
        SceneManager.LoadScene("levels"); // EXACT name
    }

      public void OpenLevel2()
    {
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1f;
    }
}
