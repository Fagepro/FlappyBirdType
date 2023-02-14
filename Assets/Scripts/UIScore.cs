using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIScore : GameController
{
    [SerializeField] private TextMeshProUGUI scoreUI;

    private void Update()
    {
        UpdateScore();
    }
    public void UpdateScore()
    {
        scoreUI.text = base.Score.ToString();
    }
}
