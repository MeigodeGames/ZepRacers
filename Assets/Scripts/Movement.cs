using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float m_MaxHeight = 10.0f;
    [SerializeField] private float m_MinSpeed = 1.0f;

    public float m_VerticalSpeed = 1000.0f;
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

        if (position.y > m_MaxHeight)
            position.y = m_MaxHeight;

        if (position.y < -m_MaxHeight)
            position.y = -m_MaxHeight;

        m_Body.MovePosition(position);
    }

    public void SpeedChange(float change)
    {
        m_HorizontalSpeed += change;

        if (m_HorizontalSpeed < m_MinSpeed)
            m_HorizontalSpeed = m_MinSpeed;
    }
}
