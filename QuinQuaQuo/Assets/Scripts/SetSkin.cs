using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSkin : MonoBehaviour
{
    public GameObject Skin_1;
    public GameObject Skin_2;
    public GameObject Skin_3;
    public GameObject Skin_4;
    public GameObject Skin_5;
    public void Set_1(){
        Skin_1.SetActive(true);
        Skin_2.SetActive(false);
        Skin_3.SetActive(false);
        Skin_4.SetActive(false);
        Skin_5.SetActive(false);
    }
    public void Set_2(){
        Skin_1.SetActive(false);
        Skin_2.SetActive(true);
        Skin_3.SetActive(false);
        Skin_4.SetActive(false);
        Skin_5.SetActive(false);
    }
    public void Set_3(){
        Skin_1.SetActive(false);
        Skin_2.SetActive(false);
        Skin_3.SetActive(true);
        Skin_4.SetActive(false);
        Skin_5.SetActive(false);
    }
    public void Set_4(){
        Skin_1.SetActive(false);
        Skin_2.SetActive(false);
        Skin_3.SetActive(false);
        Skin_4.SetActive(true);
        Skin_5.SetActive(false);
    }
    public void Set_5(){
        Skin_1.SetActive(false);
        Skin_2.SetActive(false);
        Skin_3.SetActive(false);
        Skin_4.SetActive(false);
        Skin_5.SetActive(true);
    }
}
