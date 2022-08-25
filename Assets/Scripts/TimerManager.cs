using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public static TimerManager instance;

    public Text timerText;

    public float time = 120f;
    int timeInt;

    private void Awake() {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        timerText.text = "Time: " + time.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TimerDown(){
        time -= Time.deltaTime;
        timeInt = (int)time;
        timerText.text = "Time: " + timeInt.ToString();
    }
}
