using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoison : MonoBehaviour
{
    public float _delayA = 0.2f;
    public float _delayB = 0.2f;
    public GameObject _poisonA;
    public GameObject _poisonB;

    void SpawnA(){
        Instantiate(_poisonA, new Vector3(Random.Range(-9f, 9f), 6, 0), Quaternion.identity);
    }

    void SpawnB(){
        Instantiate(_poisonB, new Vector3(Random.Range(-9f, 9f), 6, 0), Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnA", _delayA, _delayA);
        InvokeRepeating("SpawnB", _delayB, _delayB);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
