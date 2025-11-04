using UnityEngine;

public class FearZone : MonoBehaviour
{
    [SerializeField] Decorator fear;
    [SerializeField] Player player;

    private void Awake()
    {
        player = GameObject.Find("Character").GetComponent<Player>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Character")
        {
            fear.Set(player);

            fear.Activate();
        }
    }
}
