using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propler : MonoBehaviour
{
    int speed = 180;
    bool enginIsOn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            enginIsOn = true;
        }
        if(enginIsOn)
        {
            speed++;
            transform.Rotate(0, speed * Time.deltaTime, 0);
        }
    }
}
