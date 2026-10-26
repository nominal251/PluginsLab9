using UnityEngine;
using UnityEngine.Pool;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    [SerializeField] private float lifetime = 2f;

    private IObjectPool<Bullet> pool;
    private float timer;
    private bool released;

    public void SetPool(IObjectPool<Bullet> bulletPool)
    {
        pool = bulletPool;
    }

    void OnEnable()
    {
        timer = 0f;
        released = false;
    }

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);

        timer += Time.deltaTime;
        if (timer >= lifetime) Release();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Enemy>() != null) Release();
    }

    void Release()
    {
        if (released) return;
        released = true;
        pool.Release(this);
    }
}