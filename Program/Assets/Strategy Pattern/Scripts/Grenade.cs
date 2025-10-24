using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class Grenade : Weapon
{
    [SerializeField] new MeshRenderer renderer;
    [SerializeField] Material material;

    private void Awake()
    {
        renderer = GetComponentInChildren<MeshRenderer>();
    }

    public override void Attack()
    {
        Debug.Log("Grenade Attack");

        
    }

}
