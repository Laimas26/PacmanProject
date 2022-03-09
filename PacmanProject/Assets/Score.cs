using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static Score instance;
    public Text SText;
    public Text HText;

    int score = 0;
    int highscore = 0;

    private void Awake(){
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        SText.text = score.ToString() + " Coins";
        HText.text = "HIGHSCORE: " + highscore.ToString();
    }

    public void AddPoint(){
        score += 1;
        SText.text = score.ToString() + " Coins";
    }
}
