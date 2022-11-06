using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToHome : MonoBehaviour
{
    void Start()
    {
        
    }

    public void Home()
    {
        SceneManager.LoadScene("HomeSystem");
    }
}
