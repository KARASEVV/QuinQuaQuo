using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDConrol : MonoBehaviour
{
    public float rotSpeed = 2;
    public GameObject TargetPlanet;
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        bool up = Input.GetKey(KeyCode.W);
        bool left = Input.GetKey(KeyCode.A);
        bool down = Input.GetKey(KeyCode.S);
        bool right = Input.GetKey(KeyCode.D);
        
        if(up)
        {
            TargetPlanet.transform.Rotate(Vector3.left, rotSpeed);
        }
        else if(left)
        {
            TargetPlanet.transform.Rotate(Vector3.down, rotSpeed);
        }
        else if(down)
        {
            TargetPlanet.transform.Rotate(Vector3.right, rotSpeed);
        }
        else if(right)
        {
            TargetPlanet.transform.Rotate(Vector3.up, rotSpeed);
        }
        else
        {
            
        }
    }
}
