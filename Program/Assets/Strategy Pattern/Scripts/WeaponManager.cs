using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] List<Weapon> weapons;
    [SerializeField] int count = 0;

    private void Start()
    {
        for (int i = 0; i < weapons.Count; i++)
        {
            weapons[i].gameObject.SetActive(false);
        }

        weapons[count].gameObject.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Swap();
        }

        if (Input.GetMouseButton(0))
        {
            weapons[count].Attack();
        }
    }

    public void Swap()
    {
        weapons[count].gameObject.SetActive(false);

        count = (count + 1) % weapons.Count;

        weapons[count].gameObject.SetActive(true);
    }
}
