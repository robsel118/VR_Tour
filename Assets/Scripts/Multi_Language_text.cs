using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Multi_Language_text : MonoBehaviour {

    //Supported languages
    public string french;
    public string english;

    public bool progressive;

    private Text description;

    void Awake()
    {
        description = GetComponent<Text>();
        SetText();
    }
 
    void OnEnable()
    {
        if (progressive)
        {
            TypeText();
        }
        else
        {
            SetText();
        }    
    }

    void SetText()
    {
        //check language preferences
        if (PlayerPrefsManager1.GetSelectedLanguage() == "EN")
        {
            description.text = english;
        }
        else
        {
            description.text = french;
        }
    }

    public void TypeText()
    {
        //reset the text
        SetText();
        string temp = description.text;

        description.text = "";
        StartCoroutine(TypeSentence(temp));
    }

    IEnumerator TypeSentence(string temp)
    {
        for (int i = 0; i <= temp.Length; i++)
        {
            description.text = temp.Substring(0, i);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
