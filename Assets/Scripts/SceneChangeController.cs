using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeController : MonoBehaviour
{
    public static void SceneChange(string name)
    {
        SceneManager.LoadScene(name);
    }
}
