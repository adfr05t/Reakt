using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Round2Manager : MonoBehaviour
{
    [SerializeField] private List<GameObject> targetR2;
    [SerializeField] private float[] minDelay;
    [SerializeField] private float[] maxDelay;
    [SerializeField] private float[] minSpeed;
    [SerializeField] private float[] maxSpeed;
    private int waveNo;


    void Start()
    {
        StartCoroutine("PrepareWave");
    }

    IEnumerator PrepareWave()
    {
        Debug.Log(waveNo);
        float delay;

        switch (waveNo)
        {
            case 0:
                delay = Random.Range(minDelay[waveNo], maxDelay[waveNo]);
                yield return new WaitForSeconds(delay);
                Wave0();
                break;
            case 1:
                delay = Random.Range(minDelay[waveNo], maxDelay[waveNo]);
                yield return new WaitForSeconds(delay);
                Wave1();
                break;
            case 2:
                delay = Random.Range(minDelay[waveNo], maxDelay[waveNo]);
                yield return new WaitForSeconds(delay);
                Wave2();
                break;
            case 3:
                delay = Random.Range(minDelay[waveNo], maxDelay[waveNo]);
                yield return new WaitForSeconds(delay);
                Wave3();
                break;
        }
    }

    void Wave0()
    {   // choose target GO from list, set it active, give it appropriate speed, and remove it from list
        GameObject thisTarget = targetR2[Random.Range(0, targetR2.Count)];  
        thisTarget.SetActive(true);
        thisTarget.GetComponent<TargetMovement>().speed = Random.Range(minSpeed[waveNo], maxSpeed[waveNo]);
        targetR2.Remove(thisTarget);
        waveNo++;
        StartCoroutine("PrepareWave");
    }

    void Wave1()
    {
        for (int i = 0; i < 2; i++) // 2 targets
        {
            GameObject thisTarget = targetR2[Random.Range(0, targetR2.Count)];
            thisTarget.SetActive(true);
            thisTarget.GetComponent<TargetMovement>().speed = Random.Range(minSpeed[waveNo], maxSpeed[waveNo]);
            targetR2.Remove(thisTarget);
        }
        waveNo++;
        StartCoroutine("PrepareWave");

    }
    void Wave2()
    {
        for (int i = 0; i < 2; i++) // 2 targets
        {
            GameObject thisTarget = targetR2[Random.Range(0, targetR2.Count)];
            thisTarget.SetActive(true);
            thisTarget.GetComponent<TargetMovement>().speed = Random.Range(minSpeed[waveNo], maxSpeed[waveNo]);
            targetR2.Remove(thisTarget);
        }
        waveNo++;
        StartCoroutine("PrepareWave");
    }
    void Wave3()
    {
        for (int i = 0; i < 6; i++) // 6 targets
        {
            GameObject thisTarget = targetR2[Random.Range(0, targetR2.Count)];
            thisTarget.SetActive(true);
            thisTarget.GetComponent<TargetMovement>().speed = Random.Range(minSpeed[waveNo], maxSpeed[waveNo]);
            targetR2.Remove(thisTarget);
            StartCoroutine("EndRound");
        }
    }

    IEnumerator EndRound()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Round 3");
    }
}
