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
    private void OnMouseDown()
    {
        Vector3 clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 spawnPos = new Vector3(clickPos.x, clickPos.y, 0);
        Instantiate(particleEffect, spawnPos, Quaternion.identity);
        Instantiate(pointsScoredAnim, spawnPos, Quaternion.identity);
        theSFXManager.ClickTargetSFX();
        targetScript.UpdateScoreManager(myPointValue);
        Destroy(target);
    }
}
