using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevel;
    
    private void Start()
    {
        if (autoLoadNextLevel == 0) {
            Debug.Log("auto load disabled");
        }
        else{
            //Automatically loads next level after X seconds, eg for splash screen
   
            //invoke method can not take parameter
            Invoke("loadNextLevel", autoLoadNextLevel);
        }
    }

    public void LoadNextLevel(string name)
    {
        StartCoroutine(LoadLevelWithDelay(name));
    }

    //Coroutine
     IEnumerator LoadLevelWithDelay(string name)
    {
            //calling static method to fade back the cube
            FadeIn.FadBack();
        //We wait 2 seconds for our blink effect to execute
        yield return new WaitForSeconds(1);

        //Load scene according to name
        SceneManager.LoadScene(name);
    }

    public void LoadNextLevel()
    {   
        //load following scene according to build setting index
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void CloseApplication()
    {
        Application.Quit();
    }
}
