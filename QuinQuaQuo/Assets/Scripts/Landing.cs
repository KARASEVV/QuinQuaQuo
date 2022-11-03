using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landing : MonoBehaviour
{
    public GameObject Galaxy;
    public GameObject Player;
    public GameObject Rocket;
    public GameObject BackButton;
    public GameObject LandButton;
    GameObject[] Panets;
    public GameObject TargetPlanet;
    void Start(){
        Panets = GameObject.FindGameObjectsWithTag("Planet");
    }
    public void Land(){
        gameObject.GetComponent<WASDConrol>().TargetPlanet=TargetPlanet;
        Galaxy.GetComponent<RotateGalaxy>().enabled = false;
        BackButton.SetActive(false);
        LandButton.SetActive(false);
        Player = TargetPlanet.GetComponent<PlanetInfo>().Player;
        Player.SetActive(true);
        Rocket = TargetPlanet.GetComponent<PlanetInfo>().Rocket;
        Rocket.SetActive(true);
        for(int i = 0; i < Panets.Length; i++)
        {
            Panets[i].GetComponent<RotatePlanet>().rotSpeed = 0;
        }
    }
}
