using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    private int playerScore;
    public Text scoreDisplay;
    private Animator animator;


    void Start()
    {
        DontDestroyOnLoad(gameObject);
      //  SceneManager.sceneLoaded += OnSceneLoaded;
        playerScore = 0;
    }

    public void NewSceneLoaded()
    {
        scoreDisplay = GameObject.Find("ScoreDisplay").GetComponent<Text>();
        scoreDisplay.text = "" + playerScore;
        if (SceneManager.GetActiveScene().name == "Round 3")
        {
            animator = scoreDisplay.GetComponent<Animator>();
        }
    }

    public void UpdateScore(int pointsScored)
    {
        playerScore += pointsScored;
        scoreDisplay.text = "" + playerScore;
    }

    public void EndAnimation()
    {
        animator.SetTrigger("Score");
    }
}

