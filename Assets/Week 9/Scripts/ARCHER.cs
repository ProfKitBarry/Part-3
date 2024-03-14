using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARCHER : Villager
{
    public GameObject arrowPrefeb;
    public Transform spawnPoint;
    protected override void Attack()
    {
       
        destination = transform.position;
        base.Attack();
        Instantiate(arrowPrefeb, spawnPoint.position, spawnPoint.rotation);
    }
}

