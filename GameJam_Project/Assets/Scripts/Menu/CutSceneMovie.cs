using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneMovie : MonoBehaviour
{
    [SerializeField]
    private float LoadingDelay = 10f;
    [SerializeField]
    private string SceneName;
    [SerializeField]
    private float time;
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > LoadingDelay) {
            SceneManager.LoadScene(SceneName);
        }
    }
}
