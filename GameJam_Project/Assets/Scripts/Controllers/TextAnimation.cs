using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAnimation : MonoBehaviour
{
    public Text textobj;
    private string text;
    private void Start()
    {
        text = textobj.text;
        textobj.text = "";
        StartCoroutine(TextCoroutine());
    }
    IEnumerator TextCoroutine()
    {
        foreach(char abc in text) {
            textobj.text += abc;
            yield return new WaitForSeconds(0.05f); 
        }
    }
    public void QuitApplication() { 
    Application.Quit();
    }
}
