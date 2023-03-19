using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Target : MonoBehaviour
{
    private ScoreManager theScoreManager;
    private SFXManager theSFXManager;
    private Round1Manager theRound1Manager;
    [SerializeField] private SpriteRenderer rend;
    [SerializeField] private Sprite[] targetSprite;


    void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
        theSFXManager = FindObjectOfType<SFXManager>();
        rend.sprite = targetSprite[Random.Range(0, targetSprite.Length)];

        if (SceneManager.GetActiveScene().name == "Round 1")
        {
            theRound1Manager = FindObjectOfType<Round1Manager>();
        }
    }

    public void UpdateScoreManager(int myPointValue)
    {
        theSFXManager.ClickTargetSFX();
        theScoreManager.UpdateScore(myPointValue);
    }

    void OnDisable()
    {
        if (theRound1Manager != null)
        {
            theRound1Manager.PrepareNextTarget();
        }
    }
}
