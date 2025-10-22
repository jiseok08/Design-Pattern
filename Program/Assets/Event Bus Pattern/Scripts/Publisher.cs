using UnityEngine;

public class Publisher : MonoBehaviour
{
    private void Start()
    {
        EventManager.Pubish(Condition.START);
    }

    public void Publish(int condition)
    {
        EventManager.Pubish((Condition)condition);
    }
}
