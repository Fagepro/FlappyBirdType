using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D), typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private KeyCode jumpKey;
    [SerializeField] private float jumpSpeed;
    [Space(20)]
    [SerializeField] private Rigidbody2D playerRB;

    public event Action JumpPressEvent;

    private void Awake()
    {
        JumpPressEvent += OnJumpPress;
    }
    private void Update()
    {
        if (Input.GetKeyDown(jumpKey)) 
        {
            JumpPressEvent?.Invoke();
        }
    }

    private void OnJumpPress() 
    {
        playerRB.AddForce(new Vector2(0f, jumpSpeed), ForceMode2D.Impulse);
    }
}
