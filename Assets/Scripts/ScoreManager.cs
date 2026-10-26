using System;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int pointsPerKill = 10;

    public event Action<int> ScoreChanged;

    public int Score { get; private set; }

    void OnEnable() => Enemy.Destroyed += HandleEnemyDestroyed;
    void OnDisable() => Enemy.Destroyed -= HandleEnemyDestroyed;

    void HandleEnemyDestroyed()
    {
        Score += pointsPerKill;
        ScoreChanged?.Invoke(Score);
    }
}