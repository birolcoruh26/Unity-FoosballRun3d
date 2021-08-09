using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNext : MonoBehaviour
{
    public void btn_changeScene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
}
