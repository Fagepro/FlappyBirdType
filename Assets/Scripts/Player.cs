using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Collider2D playerCollider2D;

    public event Action PassOneBlockEvent;
    public event Action EarnCoinEvent;
    public event Action PlayerDeathEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PassTrigger"))
        {
            PassOneBlockEvent?.Invoke();
            EarnCoinEvent?.Invoke();
        } 
        
        if (collision.CompareTag("Block"))
        {
            PlayerDeathEvent?.Invoke();
        }
    }
}
