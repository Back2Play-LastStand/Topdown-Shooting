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

        UpdateMovement(m_playerInput.InputVec);
        UpdateAnim();
        m_playerMovement.LookAtMouse(m_playerInput.MousePos);
        m_playerAim.AimTowardsMouse(m_playerInput.MousePos);

        if (m_playerInput.MouseClick)
            m_playerShoot.Attack();
    }

    public override void UpdateMovement(Vector3 movement)
    {
        m_playerMovement.Move(movement);

        REQ_MOVE move = new();
        move.Info = PosInfo;
        Managers.Network.Send(move, (ushort)PacketId.PKT_REQ_MOVE);
    }

    public override void UpdateAnim()
    {
        m_playerMovement.PlayAnim(m_playerInput.InputVec);
    }
}
