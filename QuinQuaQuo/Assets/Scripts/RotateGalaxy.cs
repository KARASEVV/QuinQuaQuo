using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGalaxy : MonoBehaviour
{
    float rotSpeed = 20;
    void Update() {  
    if (Input.GetMouseButton(0)) {
        float rot_x = Input.GetAxis("Mouse X")*rotSpeed*Mathf.Deg2Rad;
        float rot_y = Input.GetAxis("Mouse Y")*rotSpeed*Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, -rot_x);
        transform.Rotate(Vector3.right, -rot_y);
    }  
  }
}
