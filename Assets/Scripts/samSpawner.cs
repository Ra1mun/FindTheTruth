using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class samSpawner : MonoBehaviour
{
    public static IEnumerator MoveToTarget(Transform obj, Vector3 target)
    {
        while (obj.position != target)
        {
            obj.position = Vector3.MoveTowards(obj.position, target, Time.deltaTime);
            yield return null;
        }
    }
}
