using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAppear : MonoBehaviour {
    
    private Camera camera; //Main player camera
    private MenuContoller menuContoller;

    void Start()
    {
        //Getting the menu script holding all menu panel
        camera = Camera.main;
        menuContoller = gameObject.GetComponentInChildren<MenuContoller>(true);
    }
    
    public void DisplayMenu()
    {
        //Turning the object at the same deggree than the camera
        gameObject.transform.eulerAngles = new Vector3(0, camera.transform.eulerAngles.y, 0);

        //display the first menu
        menuContoller.SwitchMenu(0);
    }
}

