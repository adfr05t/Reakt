using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDisable : MonoBehaviour
{
    private float timer;
    [SerializeField] private float lifetime;


    private void OnEnable()
    {
        timer = 0f;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= lifetime)
        {
            gameObject.SetActive(false);
        }
    }

}
