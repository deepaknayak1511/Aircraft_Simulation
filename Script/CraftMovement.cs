using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftMovement : MonoBehaviour
{
   public float speed = 1.0f;
    public int rollRate = 1;
   public float elevatorRate = 1.0f;
   public float rudderRate = 1.0f;
   public float lift = 1.2f; 
   public float gravity = 1.0f;
    
    private void Update() 
    {
        if (Input.GetKey(KeyCode.W))
        {
            speed++;
            transform.Translate(0, 0, speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, rollRate * -1 * Time.deltaTime,0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rollRate * Time.deltaTime, -0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(elevatorRate * -1 * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(elevatorRate * Time.deltaTime, 0, 0);
        }
      
    }
}
