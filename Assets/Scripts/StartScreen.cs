using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartScreen : MonoBehaviour
{
    [SerializeField] private MusicManager theMusicManager;

    private void Start()
    {
        theMusicManager.PlayIntroMusic();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Tutorial");
        }
    }
}
