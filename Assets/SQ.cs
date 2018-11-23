using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SQ : MonoBehaviour {
    public void Str() {
        SceneManager.LoadSceneAsync(1);
    }
    public void End() {
        Application.Quit();
    }
}
