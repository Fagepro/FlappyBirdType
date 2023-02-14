using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Player player;

    public int Score = 0;

    public event Action RestartGameEvent;

    private void Awake()
    {
        player.PassOneBlockEvent += OnPlayerEarnCoin;
        player.EarnCoinEvent += OnPlayerEarnCoin;
        player.PlayerDeathEvent += OnPlayerDeath;
        RestartGameEvent += OnRestartGame;
    }

    private void OnPlayerEarnCoin() 
    {
        Score++;
        Debug.Log("Score plus");
    }

    private void OnPlayerDeath() 
    {
        Time.timeScale = 0;
        RestartGameEvent?.Invoke();
    }

    private void OnRestartGame() 
    {
        Time.timeScale = 0;
        Score = 0;
    }
}
