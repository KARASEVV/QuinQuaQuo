using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSelect : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Galaxy;
    public GameObject Button;
    public GameObject LandingButton;
    float rotSpeed = 20;
    public bool movving=false;
    public Transform target;
    public Transform Planet;
    void OnMouseDown(){
        print(gameObject.name);
        Planet=gameObject.transform;
        target=gameObject.GetComponent<PlanetInfo>().cameraPosition;
        Galaxy.GetComponent<RotateGalaxy>().enabled = false;
        Camera.GetComponent<BackPosition>().Planet = gameObject;
        //gameObject.GetComponent<RotatePlanet>().enabled = true;
        movving=true;
    }
    void FixedUpdate(){
        if(movving){
            Camera.transform.position = Vector3.MoveTowards(Camera.transform.position, new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z), 0.1f);
            if(Camera.transform.position == target.transform.position){
                Camera.transform.LookAt(Planet);
                target = null;
                Button.SetActive(true);
                Camera.GetComponent<Landing>().TargetPlanet= Planet.gameObject;
                LandingButton.SetActive(true);
                movving=false;
            }
        }
    }
}
