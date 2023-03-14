using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Middle : MonoBehaviour
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
