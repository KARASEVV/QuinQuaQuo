using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VklCustom : MonoBehaviour
{
    public GameObject Menu;
    void OnMouseDown()
    {
        Menu.SetActive(!Menu.activeSelf);
    }
}
