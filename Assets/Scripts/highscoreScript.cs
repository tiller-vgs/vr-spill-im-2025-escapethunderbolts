using TMPro;
using UnityEngine;

public class highscoreScript : MonoBehaviour
{
    public float highscore;
    public TextMeshPro highscoreText;

    public int GetHighscore()
    {
        if (PlayerPrefs.HasKey("Highscore"))
        {
            highscore = PlayerPrefs.GetFloat("Highscore");
        }
        return Mathf.FloorToInt(highscore);
    }

    public void SetHighscore(float score)
    {
        if (score < highscore)
        {
            highscore = score;
            PlayerPrefs.SetFloat("Highscore", highscore);
        }
    }

    public void UpdateHighscoreText()
    {
        highscoreText.text = highscore.ToString();
    }
}
