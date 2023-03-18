using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inner : MonoBehaviour
{
    [SerializeField] int myPointValue;
    [SerializeField] GameObject target;
    [SerializeField] Target targetScript;
    private SFXManager theSFXManager;
    [SerializeField] private ParticleSystem particleEffect;
    [SerializeField] private GameObject pointsScoredAnim;


    private void Start()
    {
        theSFXManager = FindObjectOfType<SFXManager>();
    }


    void OnMouseDown()
    {
        Vector3 clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 spawnPos = new Vector3(clickPos.x, clickPos.y, 0);
        SpawnEffects(spawnPos);

        theSFXManager.ClickTargetSFX();
        targetScript.UpdateScoreManager(myPointValue);
        Destroy(target);
    }


    void SpawnEffects(Vector3 spawnPos)
    {
        Instantiate(particleEffect, spawnPos, Quaternion.identity);
        Instantiate(pointsScoredAnim, spawnPos, Quaternion.identity);
    }
}
