using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    [SerializeField] string sceneName;
    public void loadMainScreen()
    {
        SceneManager.LoadScene(sceneName);
    }
}
