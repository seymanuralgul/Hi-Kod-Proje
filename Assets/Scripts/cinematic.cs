using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cinematic : MonoBehaviour
{

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
            LoadNextScene();
    }

    void LoadNextScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        int nextLevelBuildIndex = 1 + scene.buildIndex;
        SceneManager.LoadScene(nextLevelBuildIndex);
    }
}
