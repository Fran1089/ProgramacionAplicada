using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    Vector3 _movementSpeed = new Vector3(20, 20);
    Vector3 _deltaPos = new Vector3();

    const float MIN_X = 4.0f, MAX_X = 8.0f, MIN_Y = -3.0f, MAX_Y = 3.0f;

    // Update is called once per frame
    void Update()
    {
        _deltaPos.x = Input.GetAxis("Horizontal") * _movementSpeed.x;
        _deltaPos.y = Input.GetAxis("Vertical") * _movementSpeed.y;
        _deltaPos *= Time.deltaTime;


        gameObject.transform.Translate(_deltaPos);

        gameObject.transform.position = new Vector3(
            Mathf.Clamp(gameObject.transform.position.x, MIN_X, MAX_X),
            Mathf.Clamp(gameObject.transform.position.y, MIN_Y, MAX_Y),
            gameObject.transform.position.z);
        
    }


    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
