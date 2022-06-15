using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereInstancietor : MonoBehaviour
{

    public GameObject BlueSphere, RedSphere, WhiteSphere;

    Vector3 _startingPosition = new Vector3(-10,0);

    GameObject Sphere;
    float _nextTime;
    const float MIN_TIME = 0.2f, MAX_TIME = 1.1f, MIN_Y = -3.0f, MAX_Y = 3.0f;
    Vector3 _movementSpeed = new Vector3(20, 20);
    Vector3 _deltaPos = new Vector3();

    void Start()
    {
        _nextTime = GetNextTime();
    }

    // Update is called once per frame
    void Update()
    {




        if(Time.time > _nextTime)
        {
            _startingPosition.y = Random.Range(MIN_Y, MAX_Y);
            Sphere = Instantiate(NextSphere(), _startingPosition, Quaternion.identity);
            _nextTime = GetNextTime();

        }



    }

    float GetNextTime()
    {
        return Time.time + (Random.Range(MIN_TIME, MAX_TIME));
    }

    GameObject NextSphere()
    {
        GameObject _result;
        switch(Random.Range(0,3))
        {
            case 0:
                return BlueSphere;
            case 1:
                return RedSphere;
            case 2:
                return WhiteSphere;
            default:
                return WhiteSphere;
        }
    }
}
