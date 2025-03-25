using Protocol;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayer : Player
{
    protected PlayerInput m_playerInput;

    protected override void Awake()
    {
        base.Awake();
        m_playerInput = GetComponent<PlayerInput>();
    }

    protected override void Update()
    {
        base.Update();

        UpdateMovement();
        UpdateAnim();
        UpdateRotation();
        m_playerAim.AimTowardsMouse(m_playerInput.MousePos);

        if (m_playerInput.MouseClick)
            m_playerShoot.Attack();
    }

    protected override void UpdateMovement()
    {
        m_playerMovement.Move(m_playerInput.InputVec);

        REQ_MOVE move = new();
        move.Info = PosInfo;
        Managers.Network.Send(move, (ushort)PacketId.PKT_REQ_MOVE);
    }
    protected override void UpdateRotation()
    {
        m_playerMovement.LookAtMouse(m_playerInput.MousePos);
    }

    protected override void UpdateAnim()
    {
        m_playerMovement.PlayAnim(m_playerInput.InputVec);
    }
}
