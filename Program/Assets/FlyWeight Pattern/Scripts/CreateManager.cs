using System.Collections;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] Vector3 vector;
    [SerializeField] GameObject gameObject;

    [SerializeField] float seconds;

    private void Awake()
    {
        vector = transform.position.normalized;

        gameObject.SetActive(true);
    }

    void Start()
    {
        Create();
    }

    private void Update()
    {
        
    }

    public IEnumerator Create()
    {
        while (true)
        {
            Instantiate(gameObject);
            
            gameObject.SetActive(true);
            
            yield return new WaitForSeconds(seconds);
        }
    }
}
