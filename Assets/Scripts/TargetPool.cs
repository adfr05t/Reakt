using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPool : MonoBehaviour
{
    [SerializeField] private Target targetPrefab;
    private Queue<Target> targetQueue = new Queue<Target>();

    public static TargetPool Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Target Get()
    {
        if (targetQueue.Count == 0)
        {
            AddTargets(1);
        }

        return targetQueue.Dequeue();
    }

    void AddTargets(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Target target = Instantiate(targetPrefab);
            target.gameObject.SetActive(false);
            targetQueue.Enqueue(target);
        }
    }

    public void ReturnToPool(Target target)
    {
        target.gameObject.SetActive(false);
        targetQueue.Enqueue(target);
    }
  
}
