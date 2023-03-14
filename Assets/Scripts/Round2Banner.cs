using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round2Banner : MonoBehaviour
{
    [SerializeField] private GameObject theRound2Manager;
    private ScoreManager theScoreManager;
    private SFXManager theSFXManager;


    private void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
        theScoreManager.NewSceneLoaded();
        theSFXManager = FindObjectOfType<SFXManager>();
        theSFXManager.NewRoundSFX();

    }

    void StartRound2()
    {
        theRound2Manager.SetActive(true);
        Destroy(gameObject);
    }
}
