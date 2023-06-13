using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene : MonoBehaviour
{
    [SerializeField]
    private string SceneName;
    [SerializeField]
    private GameObject Screen;
    private void OnTriggerStay(Collider other)
    {
        SceneManager.LoadScene(SceneName);
        }
    }

