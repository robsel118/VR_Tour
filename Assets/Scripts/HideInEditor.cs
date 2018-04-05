using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class HideInEditor : MonoBehaviour {

    new Renderer renderer;

    private void Awake()
    {
        //Gettig the renderer of the game object that is attached to the script
        renderer = gameObject.GetComponent<Renderer>();
    }
    void OnEnable()
    {
        //activate the renderer if not runing in editor mode or is in play mode
        renderer.enabled = !Application.isEditor || Application.isPlaying;
    }
    
    void OnDisable()
    {
        renderer.enabled = true;
    }
}
