using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMeTimer : MonoBehaviour
{
    [SerializeField] private float lifeSpan;
    private float timer = 0f;


    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= lifeSpan)
        {
            Destroy(gameObject);
        }
    }
}
