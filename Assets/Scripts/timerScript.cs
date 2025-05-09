using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timerScript : MonoBehaviour
{
    public bool isTimerActive;
    public float timeElapsed;
    public TextMeshProUGUI timerText;

    void Start()
    {
        isTimerActive = true;
        if (PlayerPrefs.HasKey("TimeElapsed"))
        {
            timeElapsed = PlayerPrefs.GetFloat("TimeElapsed");
        }
    }

    void Update()
    {
        if (isTimerActive)
        {
            float time = Time.time;
            int minutes = Mathf.FloorToInt(time / 60);
            int seconds = Mathf.FloorToInt(time % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            timeElapsed += Time.deltaTime;
            PlayerPrefs.SetFloat("TimeElapsed", timeElapsed);
        }
    }
}
