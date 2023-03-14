using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round3Banner : MonoBehaviour
{
    [SerializeField] private GameObject theRound3Manager;
    private ScoreManager theScoreManager;
    private SFXManager theSFXManager;


    private void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
        theScoreManager.NewSceneLoaded();
        theSFXManager = FindObjectOfType<SFXManager>();
        theSFXManager.NewRoundSFX();
    }

    void StartRound3()
    {
        theRound3Manager.SetActive(true);
        Destroy(gameObject);
    }
}
