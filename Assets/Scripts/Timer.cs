using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_TimerText;

    private float m_Time = 0.0f;
    private bool m_IsRunning = false;
    
    // Start is called before the first frame update
    void Start()
    {
        m_IsRunning = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!m_IsRunning) return;

        m_Time += Time.fixedDeltaTime;
        m_TimerText.SetText(m_Time.ToString("000.0"));
    }

    public float StopTimer()
    {
        m_IsRunning = false;
                
        m_TimerText.SetText(m_Time.ToString("000.0"));
        m_TimerText.color = Color.blue;

        return m_Time;
    }
}
