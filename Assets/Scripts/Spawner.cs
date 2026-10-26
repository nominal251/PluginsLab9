using UnityEngine;
using UnityEngine.InputSystem;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy enemyPrefab;

    void Start()
    {
        SpawnEnemies();
    }

    private void Update()
    {
        if (Keyboard.current.rKey.isPressed)
        {
            SpawnEnemies();
        }
    }

    void SpawnEnemies()
    {
        new EnemyBuilder(enemyPrefab)
            .WithSpeed(5f)
            .WithSize(1.5f)
            .AtPosition(new Vector3(0f, 8f, 0f))
            .Build();

        new EnemyBuilder(enemyPrefab)
            .WithSpeed(1f)
            .WithSize(0.5f)
            .WithDirection(-1)
            .AtPosition(new Vector3(0f, 6f, 0f))
            .Build();

        new EnemyBuilder(enemyPrefab)
            .WithSpeed(3f)
            .WithSize(1f)
            .AtPosition(new Vector3(0f, 4f, 0f))
            .Build();
    }
}