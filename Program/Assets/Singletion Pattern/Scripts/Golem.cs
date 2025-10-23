using UnityEngine;

public class Golem : Creature
{
    [SerializeField] float targetY;
    [SerializeField] Vector3 originPisition;

    private void Start()
    {
        originPisition = transform.position;
    }

    public override void Behaviour()
    {
        float offset = Mathf.PingPong(Time.time * speed, targetY);

        transform.position = originPisition + new Vector3(0, offset, 0);
    }
}
