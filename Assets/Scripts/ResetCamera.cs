using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCamera : MonoBehaviour {
    private Camera camera;

    void Start()
    {
        camera = Camera.main;
        gameObject.transform.eulerAngles = new Vector3(0, camera.transform.eulerAngles.y, 0);
    }

    }
