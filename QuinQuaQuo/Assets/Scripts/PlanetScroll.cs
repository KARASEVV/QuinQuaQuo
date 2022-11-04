using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetScroll : MonoBehaviour
{
    public int pos;
    public GameObject PlanetLine;
    public int instpos;
    public int intcoord;
    public GameObject Planet;
    void Start()
    {
        for(int i =0; i<intcoord; i++){
            GameObject p = Instantiate(Planet, new Vector3(i*5, 0, 0), Quaternion.identity);
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
