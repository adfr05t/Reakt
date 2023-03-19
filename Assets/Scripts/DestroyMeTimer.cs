using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMeTimer : MonoBehaviour
{
    private float timer = 0f;
    [SerializeField] private float lifeSpan;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= lifeSpan)
        {
            Destroy(gameObject);
        }
    }
}
