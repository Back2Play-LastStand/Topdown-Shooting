using Protocol;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayer : Player
{
    protected PlayerInput m_playerInput;

    protected override void Init()
    {
        base.Init();
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
            UpdateAttack();
    }

    protected override void UpdateMovement()
    {
        m_playerMovement.Move(m_playerInput.InputVec);

        if (m_playerInput.InputVec != Vector2.zero)
        {
            PosInfo.PosX += (int)m_playerInput.InputVec.x;
            PosInfo.PosY += (int)m_playerInput.InputVec.y;

            REQ_MOVE move = new();
            move.Info = PosInfo;
            Managers.Network.Send(move, (ushort)PacketId.PKT_REQ_MOVE);
        }
    }
    protected override void UpdateRotation()
    {
        m_playerMovement.LookAtMouse(m_playerInput.MousePos);
    }
    protected override void UpdateAttack()
    {
        m_playerShoot.Attack();
    }

    protected override void UpdateAnim()
    {
        m_playerMovement.PlayAnim(m_playerInput.InputVec);
    }
}
