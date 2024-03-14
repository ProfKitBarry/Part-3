using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ChesrtType {Villager, MERCHANT, ARCHER }
public class Chest : MonoBehaviour
{
    public Animator animator;
    public ChesrtType whocanopen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Villager>(out Villager villager))
        {
            if(villager.CanOpen() == whocanopen || whocanopen == ChesrtType.Villager)
            {
                animator.SetBool("IsOpened", true);
            }
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("IsOpened", false);
    }
}
