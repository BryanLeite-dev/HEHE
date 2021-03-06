using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codigoportajoint : MonoBehaviour
{
    public float[] m_Targets = { 90.0f, 0.0f };
    private int m_Index = 0;
    private HingeJoint m_Joint;

    private void Awake()
    {
        m_Joint = GetComponent<HingeJoint>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            JointSpring spring = m_Joint.spring;
            m_Index = ++m_Index % m_Targets.Length;
            spring.targetPosition = m_Targets[m_Index];
            m_Joint.spring = spring;
        }
    }

}
