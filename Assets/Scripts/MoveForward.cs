using System;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public enum MovementType
    {
        SetPosition,
        SetVelocity,
    }

    public float speed = 1;
    public MovementType movementType;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        switch (movementType)
        {
            case MovementType.SetPosition:
                transform.position += Time.deltaTime * speed * Vector3.right;
                break;
            case MovementType.SetVelocity:
                //
                break;
        }
    }

    private void FixedUpdate()
    {
        switch (movementType)
        {
            case MovementType.SetPosition:
                //
                break;
            case MovementType.SetVelocity:
                _rigidbody.velocity = new Vector2(speed, _rigidbody.velocity.y);
                break;
        }
    }
}