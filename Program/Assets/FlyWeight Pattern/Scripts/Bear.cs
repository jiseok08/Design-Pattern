using UnityEngine;
using UnityEngine.UIElements;

public class Bear : MonoBehaviour
{
    [SerializeField] float speed;

    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
