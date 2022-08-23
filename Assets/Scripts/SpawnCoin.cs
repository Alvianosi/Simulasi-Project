using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public float _delayA = 0.2f;
    public float _delayB = 0.2f;
    public float _delayC = 0.2f;
    public GameObject _coinsA;
    public GameObject _coinsB;
    public GameObject _coinsC;

    void SpawnA(){
        Instantiate(_coinsA, new Vector3(Random.Range(-9f, 9f), 6, 0), Quaternion.identity);
    }

    void SpawnB(){
        Instantiate(_coinsB, new Vector3(Random.Range(-9f, 9f), 6, 0), Quaternion.identity);
    }

    void SpawnC(){
        Instantiate(_coinsC, new Vector3(Random.Range(-9f, 9f), 6, 0), Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnA", _delayA, _delayA);
        // InvokeRepeating("SpawnB", _delayB, _delayB);
        // InvokeRepeating("SpawnC", _delayC, _delayC);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
