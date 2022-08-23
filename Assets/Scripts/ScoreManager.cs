using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;

    int score = 0;

    private void Awake() {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void PlusPoint(int amount){
        score += amount;
        scoreText.text = "Score: " + score.ToString();
    }

    public void MinusPoint(int amount){
        score -= amount;
        scoreText.text = "Score: " + score.ToString();
    }
}
