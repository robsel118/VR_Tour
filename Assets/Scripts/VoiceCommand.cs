using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VoiceCommand : MonoBehaviour {

    public Button navButton;
    public Button audioButton;

    static MenuAppear menu;

    static Button next;
    static Button audio;

    private void Awake()
    {
        next = navButton;
        audio = audioButton;
        menu = GameObject.FindObjectOfType<MenuAppear>();
    }

    public static void LaunchCommand(string command)
    {
     
        switch (command)
        {
            case "next ":
                next.onClick.Invoke();
                break;
            case "about ":
                audio.onClick.Invoke();
                break;
            case "menu ":
                menu.DisplayMenu();
                break;
        }

    }
}
