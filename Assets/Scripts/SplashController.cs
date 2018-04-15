using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashController : MonoBehaviour {

    public GameObject hesso;
    public GameObject haaga;

    void Update()
    {
        if (Time.timeSinceLevelLoad>3)
        {
            hesso.SetActive(false);
            haaga.SetActive(true);

        }
    }
}
