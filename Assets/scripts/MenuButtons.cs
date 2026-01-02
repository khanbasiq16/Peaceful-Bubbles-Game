using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void OpenHowToPlay()
    {
        SceneManager.LoadScene("howtoplay");
    }


    public void OpenSettings()
    {
        SceneManager.LoadScene("settings");
    }


  
    public void BackToMainMenu()
    {
         SceneManager.LoadScene("Mainmenu");// EXACT name
    }


    public void QuitGame()
    {
        Debug.Log("Quit Button Pressed!"); // Console mein check karne ke liye
        
        // Application band karne ke liye
        Application.Quit();

        // Agar aap Unity Editor mein test kar rahe hain toh ye line kaam karegi:
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
