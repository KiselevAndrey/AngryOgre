using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
    }

    public void LoadScene(Object scene)
    {
        SceneManager.LoadScene(scene.name);
    }
}
