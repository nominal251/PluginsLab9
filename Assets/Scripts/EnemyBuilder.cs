using UnityEngine;

public class EnemyBuilder
{
    private readonly Enemy prefab;
    private float speed = 3f;
    private float size = 1f;
    private int direction = 1;
    private Vector3 position = Vector3.zero;

    public EnemyBuilder(Enemy prefab)
    {
        this.prefab = prefab;
    }

    public EnemyBuilder WithSpeed(float value)
    {
        speed = value;
        return this;
    }

    public EnemyBuilder WithSize(float value)
    {
        size = value;
        return this;
    }

    public EnemyBuilder WithDirection(int value)
    {
        direction = value >= 0 ? 1 : -1;
        return this;
    }

    public EnemyBuilder AtPosition(Vector3 value)
    {
        position = value;
        return this;
    }

    public Enemy Build()
    {
        Enemy enemy = Object.Instantiate(prefab, position, Quaternion.identity);
        enemy.Configure(speed, size, direction);
        return enemy;
    }
}