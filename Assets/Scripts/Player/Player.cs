using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    protected PlayerInput m_playerInput;
    protected PlayerMovement m_playerMovement;
    [SerializeField] protected PlayerAim m_playerAim;
    protected PlayerShoot m_playerShoot;

    protected void Awake()
    {
        Managers manager = Managers.Instance;
        m_playerInput = GetComponent<PlayerInput>();
        m_playerMovement = GetComponent<PlayerMovement>();
        m_playerShoot = GetComponent<PlayerShoot>();
    }

    protected void Update()
    {
        m_playerMovement.Move(m_playerInput.InputVec);
        m_playerMovement.LookAtMouse(m_playerInput.MousePos);
        m_playerMovement.PlayAnim(m_playerInput.InputVec);
        m_playerAim.AimTowardsMouse(m_playerInput.MousePos);

        if(m_playerInput.MouseClick)
            m_playerShoot.Attack();
    }
}
