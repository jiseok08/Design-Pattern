using UnityEngine;

public abstract class Decorator : Debuff
{
    protected Debuff debuff;
    [SerializeField] protected Player player;

    public void Awake()
    {
        player = GameObject.Find("Character").GetComponent<Player>();
    }

    public Decorator Set(Debuff debuff)
    {
        this.debuff = debuff;
        return this;
    }   
}
