using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private Timer m_Timer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            string finishTime;
            finishTime = m_Timer.StopTimer();
            Debug.Log(finishTime);
        }
    }
}
