using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] float radius;

    [SerializeField] WaitForSeconds waitForSeconds;

    private void Awake()
    {
        waitForSeconds = new WaitForSeconds(5);
    }

    private void Start()
    {
        StartCoroutine(CreateRoutine());
    }

    public IEnumerator CreateRoutine()
    {
        while (true)
        {
            GameObject bee = ObjectPool.Instance.GetObject();

            Vector2 direction = Random.insideUnitCircle.normalized * radius;

            bee.transform.position = new Vector3(direction.x, 0, direction.y);

            yield return waitForSeconds;
        }
    }
}
