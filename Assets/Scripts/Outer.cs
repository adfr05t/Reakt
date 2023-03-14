using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outer : MonoBehaviour
{
    [SerializeField] int myPointValue;
    [SerializeField] GameObject target;
    [SerializeField] Target targetScript;


    private void OnMouseDown()
    {
        targetScript.UpdateScoreManager(myPointValue);
        Destroy(target);
    }
}
