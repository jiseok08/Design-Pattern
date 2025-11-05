using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Bee : MonoBehaviour 
{
    [SerializeField] float speed;
    [SerializeField] Vector3 direction;
    [SerializeField] Transform targetTransform;

    private void Start()
    {
        targetTransform = GameObject.Find("Sand Pillar").transform;

        direction = transform.position - targetTransform.position;

        transform.LookAt(direction);
    }

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
