using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inner : MonoBehaviour
{

    [SerializeField] int myPointValue;
    [SerializeField] GameObject target;
    [SerializeField] Target targetScript;
    private SFXManager theSFXManager;
    [SerializeField] private ParticleSystem particleEffect;
    [SerializeField] private GameObject pointsScoredAnim;
    private bool thisIsRound1;

    private void Start()
    {
<<<<<<< Updated upstream:Assets/Scripts/Inner.cs
       theSFXManager = FindObjectOfType<SFXManager>();
=======
        theSFXManager = FindObjectOfType<SFXManager>();
        thisIsRound1 = (SceneManager.GetActiveScene().name == "Round 1") ? true : false;
>>>>>>> Stashed changes:Assets/Scripts/TargetScoringArea.cs
    }
    private void OnMouseDown()
    {
        Vector3 clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 spawnPos = new Vector3(clickPos.x, clickPos.y, 0);
        Instantiate(particleEffect, spawnPos, Quaternion.identity);
        Instantiate(pointsScoredAnim, spawnPos, Quaternion.identity);
        theSFXManager.ClickTargetSFX();
<<<<<<< Updated upstream:Assets/Scripts/Inner.cs
        targetScript.UpdateScoreManager(myPointValue);
        Destroy(target);
=======
    }

    void UpdateScore()
    {
        target.UpdateScoreManager(myPointValue);
    }

    void RemoveTarget()
    {
        if (thisIsRound1)
        {
            TargetPool.Instance.ReturnToPool(target);
        }
        else
        {
            Destroy(target.gameObject);
        }
>>>>>>> Stashed changes:Assets/Scripts/TargetScoringArea.cs
    }
}
