using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void SwitchScenes(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
}
