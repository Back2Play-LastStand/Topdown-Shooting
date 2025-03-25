using Protocol;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public ulong Id { get; set; }

    PositionInfo _positionInfo = new PositionInfo();
    public PositionInfo PosInfo
    {
        get { return _positionInfo; }
        set
        {
            if (_positionInfo.Equals(value))
                return;

            _positionInfo = value;
            UpdateAnim();
        }
    }

    public Vector2 VectorPos
    {
        get { return new Vector2(PosInfo.PosX, PosInfo.PosY); }
        set
        {
            PosInfo.PosX = (int)value.x;
            PosInfo.PosY = (int)value.y;
        }
    }

    protected PlayerMovement m_playerMovement;
    protected PlayerAim m_playerAim;
    protected PlayerShoot m_playerShoot;

    protected virtual void Awake()
    {
        m_playerMovement = GetComponent<PlayerMovement>();
        m_playerShoot = GetComponent<PlayerShoot>();
        m_playerAim = GetComponent<PlayerAim>();
    }

    protected virtual void UpdateMovement()
    {
        m_playerMovement.Move(VectorPos);
    }

    protected virtual void UpdateRotation()
    {
        m_playerMovement.LookAtMouse(VectorPos);
    }

    protected virtual void Shoot(bool isShooting)
    {
        if (isShooting)
            m_playerShoot.Attack();
    }

    protected virtual void UpdateAnim()
    {
        m_playerMovement.PlayAnim(new Vector2(PosInfo.PosX, PosInfo.PosY));
    }

    protected virtual void Update()
    {
    }
}
