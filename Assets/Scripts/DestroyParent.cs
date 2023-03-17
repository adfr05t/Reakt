using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParent : MonoBehaviour
{
    void DestroyGameObjects()
    {
        Destroy(gameObject.transform.parent.gameObject);
    }
}
