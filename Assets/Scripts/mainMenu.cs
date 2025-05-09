using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        timerScript timer = Object.FindFirstObjectByType<timerScript>();
        if (timer != null)
        {
            timer.StartTimer(true);
        }

        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
