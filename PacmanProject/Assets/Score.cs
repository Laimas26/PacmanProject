using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    public static Score instance;
    public Text SText;
    public Text HText;

    int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        SText.text = score.ToString() + " Coins";
        HText.text = "HIGHSCORE: " + highscore.ToString();
    }
    public void AddPoint()
    {
        score += 1;
        SText.text = score.ToString() + " Coins";
        PlayerPrefs.SetInt("score", score);

        if (highscore < score)
        {
            HText.text = "NEW HIGHSCORE:" + score.ToString();
            PlayerPrefs.SetInt("highscore", score);
        }
        if (score == 10)
        {
            SceneManager.LoadScene(1);
        }
    }
}