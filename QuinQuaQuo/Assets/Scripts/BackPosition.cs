using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPosition : MonoBehaviour
{
    public bool moveBack = false;
    public GameObject Button;
    public GameObject Button_1;
    public GameObject Planet;
    public GameObject Player;
    public GameObject Rocket;
    public Transform backTrans;
    public Transform Galaxy;
    public void BackPos(){
        moveBack = true;
        Galaxy.GetComponent<RotateGalaxy>().enabled = true;
        Player = Planet.GetComponent<PlanetInfo>().Player;
        Player.SetActive(false);
        Rocket = Planet.GetComponent<PlanetInfo>().Rocket;
        Rocket.SetActive(false);
    }
    void FixedUpdate(){
        if(moveBack){
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(backTrans.transform.position.x, backTrans.transform.position.y, backTrans.transform.position.z), 0.1f);
            if(gameObject.transform.position == backTrans.transform.position){
                moveBack=false;
                Button.SetActive(false);
                Button_1.SetActive(false);
                gameObject.transform.LookAt(Galaxy);
            }
        }
    }
}
