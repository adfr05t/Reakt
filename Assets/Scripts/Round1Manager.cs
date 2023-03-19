using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Round1Manager : MonoBehaviour
{
    [SerializeField] private GameObject target;
    private float healthValue = 1;
    [SerializeField] private Transform timerFill;
    private bool targetOnScreen;


    void Start()
    {
        StartCoroutine("DelaySpawn");
    }

    IEnumerator DelaySpawn()
    {
        yield return new WaitForSeconds(Random.Range(0.2f, 4.0f));
        SpawnTarget();
    }

    void SpawnTarget()
    {
        int zone = Random.Range(1, 6);
        float xPos, yPos;

        switch (zone)
        {
            case 1:
                 xPos = Random.Range(-7.7f, -3.38f);
                 yPos = Random.Range(-3.8f, 3.8f);
                break;

            case 2:
                 xPos = Random.Range(-3.37f, -2.2f);
                 yPos = Random.Range(-2.75f, 3.8f);
                break;

            case 3:
                 xPos = Random.Range(-2.19f, 2.19f);
                 yPos = Random.Range(-2.75f, 1.8f);
                break;

            case 4:
                 xPos = Random.Range(2.2f, 3.37f);
                 yPos = Random.Range(-2.75f, 3.8f);
                break;

            case 5:
                 xPos = Random.Range(3.38f, 7.7f);
                 yPos = Random.Range(-3.8f, 3.8f);
                break;

            default:        // had to put default values to avoid unassigned var error
                xPos = 4f;
                yPos = 1f;
                break;
        }

        // Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
        var newTarget = TargetPool.Instance.Get();
        newTarget.transform.position = new Vector2(xPos, yPos);
        newTarget.gameObject.SetActive(true);
        targetOnScreen = true;
    }

    void Update()
    {
        UpdateHealth();
    }

    public void PrepareNextTarget()
    {
        targetOnScreen = false;
        StartCoroutine("DelaySpawn");
    }

    void UpdateHealth()
    {
        if (targetOnScreen)
        {
            healthValue -= 0.12f * Time.deltaTime;
        }

        if (healthValue < 0)
        {
            // end round 1
            SceneManager.LoadScene("Round 2");
        }
        timerFill.localScale = new Vector3(healthValue, 1, 1);
    }
}

