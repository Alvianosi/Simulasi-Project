using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public int minusScoreA = 1;
    public int minusScoreB = 1;
    public int plusScoreA = 1;
    public int plusScoreB = 1;
    public int plusScoreC = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnBecameInvisible() {
        Destroy(gameObject);
     }

    private void OnTriggerEnter2D(Collider2D collision) {
        //gh.score -= minusScoreA;
        // Destroy(gameObject);
        
        switch(gameObject.tag)
        {
            case "PoisonA":
                ScoreManager.instance.MinusPoint(minusScoreA);
                Destroy(gameObject);
                break;
            case "PoisonB":
                ScoreManager.instance.MinusPoint(minusScoreB);
                Destroy(gameObject);
                break;
            case "CoinsA":
                ScoreManager.instance.PlusPoint(plusScoreA);
                Destroy(gameObject);
                break;
        }
    }
}
