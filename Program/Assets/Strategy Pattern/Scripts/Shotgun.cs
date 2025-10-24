using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Shotgun : Weapon
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform createPosition;

    public override void Attack()
    {
        Instantiate(bullet, createPosition.position, Quaternion.Euler(90,0,0));
    }
}
