using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MERCHANT : Villager
{
    public override ChesrtType CanOpen()
    {
        return ChesrtType.MERCHANT;
    }
}
