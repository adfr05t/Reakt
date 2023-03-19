using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScoringArea : MonoBehaviour
{
    [SerializeField] int myPointValue;
    [SerializeField] Target target;
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
        PlaySound();
        UpdateScore();
        RemoveTarget();
    }

    void SpawnEffects(Vector3 spawnPos)
    {
        Instantiate(particleEffect, spawnPos, Quaternion.identity);
        Instantiate(pointsScoredAnim, spawnPos, Quaternion.identity);
    }

    void PlaySound()
    {
        theSFXManager.ClickTargetSFX();
    }

    void UpdateScore()
    {
        target.UpdateScoreManager(myPointValue);
    }

    void RemoveTarget()
    {
        // TargetPool.Instance.ReturnToPool(target);
        Destroy(target.gameObject);
    }
}
