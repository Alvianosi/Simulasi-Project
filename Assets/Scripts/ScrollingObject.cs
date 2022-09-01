using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _height;
    [SerializeField] private float _timeSet;
    float _time;
    int _timeInt;
    public GameObject _obj;
    // Update is called once per frame
    private void Start() {
        _time = _timeSet;
    }
    void Update()
    {
        transform.position += new Vector3(0, -_speed*Time.deltaTime, 0);
        Spawn();
    }

    void Spawn(){
        _time -= Time.deltaTime;
        _timeInt = (int)_time;
        if (_timeInt < 0){
            Instantiate(_obj, new Vector3(0, _height, 0), Quaternion.identity);
            _time = _timeSet;
        }
    }

    private void OnBecameInvisible() {
        Destroy(gameObject);
    }
}
