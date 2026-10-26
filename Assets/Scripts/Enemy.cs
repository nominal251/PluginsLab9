using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static event Action Destroyed;

    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float boundary = 7.5f;

    private int direction = 1;

    public void Configure(float speed, float size, int startDirection)
    {
        moveSpeed = speed;
        direction = startDirection;
        transform.localScale = Vector3.one * size;
    }

    void Update()
    {
        transform.Translate(Vector3.right * direction * moveSpeed * Time.deltaTime, Space.World);

        float x = transform.position.x;
        if (Mathf.Abs(x) >= boundary) direction = x > 0 ? -1 : 1;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroyed?.Invoke();
        Destroy(gameObject);
    }
}