using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetScroll : MonoBehaviour
{
    public int pos;
    public GameObject PlanetLine;
    public int instpos;
    public int intcoord;
    public GameObject[] Planet;
    public GameObject PlanetProto;
    void Start()
    {
        for(int i =0; i<intcoord; i++){
            //GameObject p = Instantiate(Planet[Random.Range(0, Planet.Length-1)], new Vector3(i*5, 0, 0), Quaternion.identity);
            GameObject p = Instantiate(PlanetProto, new Vector3(i*5, 0, 0), Quaternion.identity);
            p.GetComponent<CreatePlanet>().PlanetMash = Planet[Random.Range(0, Planet.Length-1)];
            p.GetComponent<CreatePlanet>().t_1 = "Название Идеи";
            p.GetComponent<CreatePlanet>().t_2 = "Автор";
            p.transform.SetParent(PlanetLine.transform);
        }
    }
    void FixedUpdate()
    {
        PlanetLine.transform.position = Vector3.MoveTowards(PlanetLine.transform.position, new Vector3(pos, 0, 0), 0.2f);
    }
    public void scroll_left()
    {
        if(pos!=(intcoord-1)*-5)
            pos = pos-5;
    }
    public void scroll_right()
    {
        if(pos!=0)
        pos = pos+5;
    }
}
