using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outer : MonoBehaviour
{
    [SerializeField] int myPointValue;
    [SerializeField] GameObject target;
    [SerializeField] Target targetScript;
    private SFXManager theSFXManager;

    private void Start()
    {
        theSFXManager = FindObjectOfType<SFXManager>();
    }


    private void OnMouseDown()
    {
        theSFXManager.ClickTargetSFX();
        targetScript.UpdateScoreManager(myPointValue);
        Destroy(target);
    }
}
