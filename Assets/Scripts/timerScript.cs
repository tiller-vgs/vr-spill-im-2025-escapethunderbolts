using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timerScript : MonoBehaviour
{
    public bool isTimerActive;
    public float timeElapsed;
    public TextMeshProUGUI timerText;

    void Awake()
    {
        if (Object.FindObjectsByType<timerScript>(FindObjectsSortMode.None).Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
        isTimerActive = false;
    }

    public void StartTimer(bool reset)
    {
        if (reset)
        {
            PlayerPrefs.DeleteKey("TimeElapsed");
            timeElapsed = 0f;
        }
        else if (PlayerPrefs.HasKey("TimeElapsed"))
        {
            timeElapsed = PlayerPrefs.GetFloat("TimeElapsed");
        }
        isTimerActive = true;
    }

    void Update()
    {
        if (isTimerActive)
        {
            timeElapsed += Time.deltaTime;
            int minutes = Mathf.FloorToInt(timeElapsed / 60);
            int seconds = Mathf.FloorToInt(timeElapsed % 60);
            if (timerText != null)
            {
                timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            }
            PlayerPrefs.SetFloat("TimeElapsed", timeElapsed);
        }
    }

    public void StopTimer()
    {
        isTimerActive = false;
        GetComponent<highscoreScript>().SetHighscore(timeElapsed);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
