using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioClip introLoop, fullTheme;
    [SerializeField] AudioSource audioSource;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void PlayIntroMusic()
    {
        audioSource.clip = introLoop;
        audioSource.Play();
    }

    public void PlayMainMusic()
    {
        audioSource.clip = fullTheme;
        audioSource.Play();
    }

}
