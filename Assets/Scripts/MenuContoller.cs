using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuContoller : MonoBehaviour {

    public List<GameObject> menus;  //List of every menu panel
    public int menuSelected = -1;     //the menu to display according to list, set to -1 to display none

    public void SwitchMenu(int selected)
    {
        //setting new value
        menuSelected = selected;
    }
	
    private void RenderMenu()
    {
        //loop the list and display the selected one
        for (int i = 0;i<menus.Count;i++)
        {
            if (i==menuSelected)
            {
                menus[menuSelected].SetActive(true);
            }
            else
            {
                menus[i].SetActive(false);
            }
        }
    }

	void Update () {
        RenderMenu();
    }

    public void HideUI()
    {
        // set the value to negative to hide all nemu
        menuSelected = -1;
    }
}
