using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField]
    private int sceneIndexToLoad;

    // Method to be called when the button is clicked
    public void ChangeSceneByIndex()
    {
        SceneManager.LoadScene(sceneIndexToLoad);
    }
}