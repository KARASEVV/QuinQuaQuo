using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlanet : MonoBehaviour
{
    public GameObject PlanetMash;
    public GameObject Text_1;
    public GameObject Text_2;
    public string t_1;
    public string t_2;
    void Start()
    {
        GameObject p = Instantiate(PlanetMash, gameObject.transform.position, Quaternion.identity);
        p.transform.SetParent(gameObject.transform);
        Text_1.GetComponent<TextMesh>().text = t_1;
        Text_2.GetComponent<TextMesh>().text = t_2;
    }
}
