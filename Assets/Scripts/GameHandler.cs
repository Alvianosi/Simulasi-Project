using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public int score;
    public GameOverScreen GameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        TimerManager.instance.TimerDown();
        GameOver();
    }

    public void GameOver(){
        if(TimerManager.instance.time < 0){
            GameOverScreen.Setup(ScoreManager.instance.score);
        }
    }


}
