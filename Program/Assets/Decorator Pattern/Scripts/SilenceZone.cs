using Unity.VisualScripting;
using UnityEngine;

public class SilenceZone : MonoBehaviour
{
    [SerializeField] Decorator silenece;
    [SerializeField] Player player;

    public bool unlock = false;

    private void Awake()
    {
        player = GameObject.Find("Character").GetComponent<Player>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Character")
        {
            silenece.Set(player);

            silenece.Activate();

            unlock = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        unlock = false;
    }
}
