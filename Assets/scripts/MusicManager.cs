
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public static MusicManager Instance;
    public AudioSource audioSource;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Find Settings button in the scene
        Button settingsButton = GameObject.Find("SettingsButton")?.GetComponent<Button>();
        if (settingsButton != null)
        {
            // Add listener only once
            settingsButton.onClick.RemoveListener(ToggleMusic); // remove old if exists
            settingsButton.onClick.AddListener(ToggleMusic);    // add correct listener
        }
    }

    public void ToggleMusic()
    {
        if (audioSource.isPlaying)
            audioSource.Pause();
        else
            audioSource.Play();
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
