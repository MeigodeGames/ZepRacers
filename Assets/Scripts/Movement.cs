using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    public float m_VerticalSpeed = 10000000.0f;
    public float m_HorizontalSpeed = 2.0f;

    private Rigidbody m_Body;

    private void Awake()
    {
        m_Body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }

    private Vector3 VerticalMove()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            return transform.up * m_VerticalSpeed * Time.fixedDeltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            return transform.up * -m_VerticalSpeed * Time.fixedDeltaTime;
        }

        return Vector3.zero;
    }

    private Vector3 HorizontalMove()
    {
        return transform.forward * m_HorizontalSpeed * Time.fixedDeltaTime;
    }

    private void Move()
    {
        var position = m_Body.position + VerticalMove() + HorizontalMove();
        m_Body.MovePosition(position);
    }
}
