using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour, IPlayerInput
{
    private Vector3 m_inputVec;
    public Vector3 InputVec => m_inputVec;

    private Vector3 m_mousePos;
    public Vector3 MousePos => m_mousePos;

    public void OnMove(InputValue value)
    {
        m_inputVec = value.Get<Vector3>();
    }

    public void OnLook(InputValue value)
    {
        m_mousePos = value.Get<Vector3>();
    }
}
