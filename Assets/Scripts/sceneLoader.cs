using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void EndGame()
    {
        Debug.Log("Game Completed");
        SceneManager.LoadScene(0);
        GetComponent<timerScript>().StopTimer();
    }
}
