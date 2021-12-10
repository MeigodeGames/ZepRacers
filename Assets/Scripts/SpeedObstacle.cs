using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedObstacle : MonoBehaviour
{
    [SerializeField] private float m_SpeedChange = 0.25f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Movement>().SpeedChange(m_SpeedChange);
        }
    }
}
