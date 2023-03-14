using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    [SerializeField] private float xDirMin, xDirMax;
    private float xDir;
    [SerializeField] private float yDir;
    public float speed; // speed value decided (from a range) in Round2Manager.cs
    [SerializeField] private float travelLimit;
    private Vector3 startPos;



    void Start()
    {
        xDir = Random.Range(xDirMin, xDirMax);
        startPos = transform.position;
    }


    void Update()
    {
        transform.Translate(new Vector2(xDir, yDir) * speed * Time.deltaTime);

        if (startPos.y > 0)
        {
            if (transform.position.y < travelLimit)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            if (transform.position.y > travelLimit)
            {
                Destroy(gameObject);
            }
        }
    }
}
