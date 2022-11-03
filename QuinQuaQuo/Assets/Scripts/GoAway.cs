using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoAway : MonoBehaviour
{
    public GameObject backButton;
    void OnTriggerEnter(Collider other){
        backButton.SetActive(true);
    }
}
