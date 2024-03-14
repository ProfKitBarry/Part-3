using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thirves : Villager
{
    public GameObject fly;
    public Transform knife;
    float speed1;
    public override ChesrtType CanOpen()
    {
        return ChesrtType.Thieves;
    }
    //void update()
    //{
    //    if (Input.GetKeyDown(KeyCode.K)|| Input.GetKeyDown(KeyCode.L)) {

    //        Instantiate(fly, knife.position, knife.rotation);

    //    }
    //}

    protected override void Attack()
    {
        base.Attack();
        

        Instantiate(fly, knife.position, knife.rotation);
    }

}
