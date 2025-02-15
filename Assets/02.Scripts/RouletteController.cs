using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0f;    //회전 속도
    bool isRotate = false;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isRotate)
        {
            isRotate = true;
            rotSpeed = Random.Range(3f, 10F);
        }

        transform.Rotate(0, 0, rotSpeed);
        rotSpeed *= 0.998f;
        if (rotSpeed < 0.01f)
        {
            rotSpeed = 0;
            isRotate = false;
        }

        if (Input.GetMouseButtonDown(1) && !isRotate)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
