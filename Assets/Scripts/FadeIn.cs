using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {

    public float fadeInTime;
    private Renderer renderer;
    private Color currentColour = Color.black;
    static int fadeDirection;

    void Start () {
        //getting the Mesh Renderer of the cube attached to the script
        renderer = gameObject.GetComponent<Renderer>();
        //Start fading animation
        FadeOut();
	}

    void Update()
    {
        //waiting one second for the video to load approriatly
        if (Time.timeSinceLevelLoad>1)
        {
            //execute the code only during transition
            if ((fadeDirection == 1 && currentColour.a < 1)||(fadeDirection==-1&&currentColour.a>0))
            {
                currentColour.a += fadeDirection * fadeInTime * Time.deltaTime;
                currentColour.a = Mathf.Clamp01(currentColour.a);
                renderer.material.color = currentColour;
            }
           
        }
    }

    public static void FadBack()
    {
        fadeDirection = 1;
    }

    void FadeOut()
    {
        fadeDirection = -1;
    }


    //LEGACY
    // Update is called once per frame
    //void Update()
    //{
    //    //wait 1 second for the video to load properly
    //    if (Time.timeSinceLevelLoad > 1)
    //    {
    //        //Start fading out the cube
    //        if (Time.timeSinceLevelLoad < fadeInTime + 1)
    //        {
    //            float alphaChange = Time.deltaTime / fadeInTime;
    //            currentColour.a -= alphaChange;
    //            renderer.material.color = currentColour;
    //        }
    //    }



    //    //Start fading in the cube once it is active again
    //    if (active && renderer.material.color.a <= 1)
    //    {
    //        float alphaChange = Time.deltaTime;
    //        currentColour.a += alphaChange;
    //        renderer.material.color = currentColour;
    //    }

    //}
}
