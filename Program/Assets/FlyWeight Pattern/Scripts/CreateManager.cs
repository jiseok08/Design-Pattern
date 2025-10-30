using System.Collections;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] Transform createPosition;

    void Start()
    {
        StartCoroutine(Create());
    }

    IEnumerator Create()
    {
        while (true)
        {         
            yield return CoroutineManager.GetCachedWait(Random.RandomRange(1, 6));
            
            Instantiate(prefab, createPosition.position, prefab.transform.rotation);
        }
    }
}
