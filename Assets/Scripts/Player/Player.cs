using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerInput m_playerInput;
    private PlayerMovement m_playerMovement;
    [SerializeField] private PlayerAim m_playerAim;

    void Awake()
    {
        m_playerInput = GetComponent<PlayerInput>();
        m_playerMovement = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        m_playerMovement.Move(m_playerInput.InputVec);
        m_playerMovement.LookAtMouse(m_playerInput.MousePos);
        m_playerMovement.PlayAnim(m_playerInput.InputVec);
        m_playerAim.AimTowardsMouse(m_playerInput.MousePos);
    }
}
