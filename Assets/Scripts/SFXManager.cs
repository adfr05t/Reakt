using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    [SerializeField] private AudioClip clickTarget, newRound;
    [SerializeField] private float clickTargetVol, newRoundVol;
    [SerializeField] private AudioSource audioSource;


    public void NewRoundSFX()
    {
        audioSource.clip = newRound;
        audioSource.volume = newRoundVol;
        audioSource.Play();
    }

    public void ClickTargetSFX()
    {
      //  audioSource.clip = clickTarget;
      //  audioSource.volume = clickTargetVol;
        audioSource.Play();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            ClickTargetSFX();
        }
    }
}
