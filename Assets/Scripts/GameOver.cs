using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    float currentTime = 0;

    void Update()
    {
        currentTime += Time.deltaTime;

        if (Input.anyKeyDown && currentTime > 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // ¾À Àç ·Îµù
        }
    }
}
