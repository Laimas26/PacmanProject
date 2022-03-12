using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public static MainMenu instance;
    public Text SText;
    public Text HText;

    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        score = PlayerPrefs.GetInt("score", 0);
        highscore = PlayerPrefs.GetInt("highscore", 0);
        SText.text = score.ToString() + " Coins";
        HText.text = "HIGHSCORE: " + highscore.ToString();
    }


    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}