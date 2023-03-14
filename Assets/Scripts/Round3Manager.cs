using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Round3Manager : MonoBehaviour
{
    [SerializeField] private GameObject target;
    private float healthValue = 1f;
    [SerializeField] private RectTransform healthFill;
    [SerializeField] private GameObject timerFill;
    private ScoreManager theScoreManager;
    private MusicManager theMusicManager;

    private bool targetsOnscreen; // used to start health/timer
    // choose 4 zones in which a target will NOT be spawned...
    int[] skipZone = new int[4];
    //...and choose them from a list (so no duplicates will occur) 
    List<int> possSkipZones = new List<int>();

    void Start()
    {
        theMusicManager = FindObjectOfType<MusicManager>();
        theScoreManager = FindObjectOfType<ScoreManager>();
        StartCoroutine("DelaySpawn");
        // populate list with no's 0 - 27
        for (int i = 0; i < 28; i++)
        {
            possSkipZones.Add(i);
        }
    }

    IEnumerator DelaySpawn()
    {
        yield return new WaitForSeconds(Random.Range(0.2f, 4.0f));
        DetermineCoordinates();
    }

    void DetermineCoordinates()
    {
        // choose zones in which to skip spawning a target
        for (int i = 0; i < skipZone.Length; i++)
        {
            // choose from a list of ints, then remove 
            int rand = Random.Range(0, possSkipZones.Count);
            skipZone[i] = possSkipZones[rand];
            possSkipZones.Remove(possSkipZones[rand]);
            Debug.Log(skipZone[i]);
        }

        for (int zone = 0; zone < 28; zone++)
        {
            float xPos, yPos;

            switch (zone)
            {
                case 0:
                    if (SkipThisZone(0))
                    {
                        break;
                    }
                    xPos = Random.Range(-7.88f, -6.14f);
                    yPos = Random.Range(2.9f, 4.12f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;

                case 1:
                    if (SkipThisZone(1))
                    {
                        break;
                    }
                    xPos = Random.Range(-5.06f, -3.3f);
                    yPos = Random.Range(2.9f, 4.12f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;
                    //-------------------------------------
                case 2:
                    if (SkipThisZone(2))
                    {
                        break;
                    }
                    xPos = Random.Range(-7.88f, -7.09f);
                    yPos = Random.Range(0.58f, 1.8f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;

                case 3:
                    if (SkipThisZone(3))
                    {
                        break;
                    }
                    xPos = Random.Range(-6f, -5.21f);
                    yPos = Random.Range(0.58f, 1.8f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;

                case 4:
                    if (SkipThisZone(4))
                    {
                        break;
                    }
                    xPos = Random.Range(-4.13f, -3.29f);
                    yPos = Random.Range(0.58f, 1.8f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;
                    //---------------------------------
                case 5:
                    if (SkipThisZone(5))
                    {
                        break;
                    }
                    xPos = Random.Range(-7.88f, -7.09f);
                    yPos = Random.Range(-1.76f, -0.51f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;

                case 6:
                    if (SkipThisZone(6))
                    {
                        break;
                    }
                    xPos = Random.Range(-6f, -5.21f);
                    yPos = Random.Range(-1.76f, -0.51f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;

                case 7:
                    if (SkipThisZone(7))
                    {
                        break;
                    }
                    xPos = Random.Range(-4.13f, -3.29f);
                    yPos = Random.Range(-1.76f, -0.51f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;
                    //------------------------------------
                case 8:
                    if (SkipThisZone(8))
                    {
                        break;
                    }
                    xPos = Random.Range(-7.88f, -7.09f);
                    yPos = Random.Range(-4.09f, -2.81f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;

                case 9:
                    if (SkipThisZone(9))
                    {
                        break;
                    }
                    xPos = Random.Range(-6f, -5.21f);
                    yPos = Random.Range(-4.09f, -2.81f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;

                case 10:
                    if (SkipThisZone(10))
                    {
                        break;
                    }
                    xPos = Random.Range(-4.13f, -3.29f);
                    yPos = Random.Range(-4.09f, -2.81f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;
                    //-----------------------------------
                    //-----------------------------------
                case 11:
                    if (SkipThisZone(11))
                    {
                        break;
                    }
                    xPos = Random.Range(-2.24f, -1.37f);
                    yPos = Random.Range(-0.03f, 1.76f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;

                case 12:
                    if (SkipThisZone(12))
                    {
                        break;
                    }
                    xPos = Random.Range(-0.39f, 0.48f);
                    yPos = Random.Range(-0.03f, 1.76f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;

                case 13:
                    if (SkipThisZone(13))
                    {
                        break;
                    }
                    xPos = Random.Range(1.48f, 2.37f);
                    yPos = Random.Range(-0.03f, 1.76f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;
                    //----------------------------------------
                case 14:
                    if (SkipThisZone(14))
                    {
                        break;
                    }
                    xPos = Random.Range(-2.24f, -1.37f);
                    yPos = Random.Range(-2.8f, -1.09f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;

                case 15:
                    if (SkipThisZone(15))
                    {
                        break;
                    }
                    xPos = Random.Range(-0.39f, 0.48f);
                    yPos = Random.Range(-2.8f, -1.09f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;

                case 16:
                    if (SkipThisZone(16))
                    {
                        break;
                    }
                    xPos = Random.Range(1.48f, 2.37f);
                    yPos = Random.Range(-2.8f, -1.09f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;
                //----------------------------------
                //----------------------------------

                case 17:
                    if (SkipThisZone(17))
                    {
                        break;
                    }
                    xPos = Random.Range(3.3f, 4.27f);
                    yPos = Random.Range(2.9f, 4.12f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;

                case 18:
                    if (SkipThisZone(18))
                    {
                        break;
                    }
                    xPos = Random.Range(5.24f, 6.18f);
                    yPos = Random.Range(2.9f, 4.12f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;

                case 19:
                    if (SkipThisZone(19))
                    {
                        break;
                    }
                    xPos = Random.Range(7.17f, 8f);
                    yPos = Random.Range(2.9f, 4.12f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;
                //----------------------------------

                case 20:
                    if (SkipThisZone(20))
                    {
                        break;
                    }
                    xPos = Random.Range(3.3f, 4.27f);
                    yPos = Random.Range(0.58f, 1.8f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;

                case 21:
                    if (SkipThisZone(21))
                    {
                        break;
                    }
                    xPos = Random.Range(5.24f, 6.18f);
                    yPos = Random.Range(0.58f, 1.8f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;

                case 22:
                    if (SkipThisZone(22))
                    {
                        break;
                    }
                    xPos = Random.Range(7.17f, 8f);
                    yPos = Random.Range(0.58f, 1.8f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;
                //----------------------------------

                case 23:
                    if (SkipThisZone(23))
                    {
                        break;
                    }
                    xPos = Random.Range(3.3f, 4.27f);
                    yPos = Random.Range(-1.76f, -0.51f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;

                case 24:
                    if (SkipThisZone(24))
                    {
                        break;
                    }
                    xPos = Random.Range(5.24f, 6.18f);
                    yPos = Random.Range(-1.76f, -0.51f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;

                case 25:
                    if (SkipThisZone(25))
                    {
                        break;
                    }
                    xPos = Random.Range(7.17f, 8f);
                    yPos = Random.Range(-1.76f, -0.51f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;
                //----------------------------------

                case 26:
                    if (SkipThisZone(26))
                    {
                        break;
                    }
                    xPos = Random.Range(3.44f, 5.22f);
                    yPos = Random.Range(-4.09f, -2.81f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;

                case 27:
                    if (SkipThisZone(27))
                    {
                        break;
                    }
                    xPos = Random.Range(6.22f, 8f);
                    yPos = Random.Range(-4.09f, -2.81f);
                    Instantiate(target, new Vector2(xPos, yPos), Quaternion.identity);
                    break;
            }
        }
        targetsOnscreen = true;
    }

    bool SkipThisZone(int zoneToCheck)
    {
        foreach (var nonSpawnZone in skipZone)
        {
            if (zoneToCheck == nonSpawnZone)
            {
                return true;
            }
        }
        return false;
    }

    void Update()
    {
        UpdateHealth();
    }

    void UpdateHealth()
    {
        if (targetsOnscreen)
        {
            healthValue -= 0.08f * Time.deltaTime;

            if (healthValue < 0)
            {
                // end round 3: destroy timerFill and remaining targets
                Destroy(timerFill);
                Target[] remainingTargets = FindObjectsOfType<Target>();
                foreach (var target in remainingTargets)
                {
                    Destroy(target.gameObject);
                }
                targetsOnscreen = false;
                // start score animation
                theScoreManager.EndAnimation();
                StartCoroutine("ReturnToMenu");
            }
            timerFill.transform.localScale = new Vector3(healthValue, 1, 1);
        }
    }

    IEnumerator ReturnToMenu()
    {
        yield return new WaitForSeconds(3.5f);
        Destroy(theScoreManager.gameObject);
        Destroy(theMusicManager.gameObject);

        SceneManager.LoadScene("StartScreen");
    }
}
