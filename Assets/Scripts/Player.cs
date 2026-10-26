using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    void Update()
    {
        float input = 0f;

        if (Keyboard.current.aKey.isPressed) input -= 1f;
        if (Keyboard.current.dKey.isPressed) input += 1f;

        transform.Translate(Vector3.right * input * moveSpeed * Time.deltaTime);
    }
}