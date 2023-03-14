using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round1Banner : MonoBehaviour
{
    [SerializeField] private GameObject theRound1Manager;
    private MusicManager theMusicManager;
   // private SFXManager theSFXManager;

    private void Start()
    {
        theMusicManager = FindObjectOfType<MusicManager>();
        theMusicManager.PlayMainMusic();
   //     theSFXManager = FindObjectOfType<SFXManager>();
    //    theSFXManager.NewRoundSFX();

    }

    void StartRound1()
    {
        theRound1Manager.SetActive(true);
        Destroy(gameObject);
    }

}
