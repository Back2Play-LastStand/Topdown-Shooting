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
            _destPos = new Vector3(value.PosX, transform.position.y, value.PosY);
            transform.position = _destPos;
            //UpdateAnim();
        }
    }

    public Vector3 VectorPos
    {
        get { return new Vector3(PosInfo.PosX, transform.position.y, PosInfo.PosY); }
        set
        {
            if (PosInfo.PosX == value.x && PosInfo.PosY == value.y)
                return;

            PosInfo.PosX = value.x;
            PosInfo.PosY = value.z;
        }
    }

    protected MoveDir _lastDir = MoveDir.Down;
    public MoveDir Dir
    {
        get { return PosInfo.MoveDir; }
        set
        {
            if (PosInfo.MoveDir == value)
                return;

            PosInfo.MoveDir = value;
            if (value != MoveDir.None)
                _lastDir = value;
        }
    }

    protected PlayerMovement m_playerMovement;
    protected PlayerShoot m_playerShoot;

    protected Vector3 _destPos;

    protected virtual void Start()
    {
        Init();
    }

    protected virtual void Init()
    {
        m_playerMovement = GetComponent<PlayerMovement>();
        m_playerShoot = GetComponent<PlayerShoot>();
        _destPos = transform.position;
    }

    protected virtual void UpdateMovement()
    {
        Vector3 currentPos = transform.position;
        if (currentPos != _destPos)
        {
            Vector3 moveDir = _destPos - currentPos;
            float dist = moveDir.magnitude;
            float moveStep = m_playerMovement.m_speed * Time.deltaTime;

            if (dist < moveStep)
            {
                transform.position = _destPos;
            }
            else
            {
                transform.position += moveDir.normalized * moveStep;
            }
        }

        UpdateAnim();
    }
    protected virtual void UpdateRotation()
    {
        Vector3 moveDir = _destPos - transform.position;

        if(moveDir.sqrMagnitude > 0.001f)
        {
            moveDir.y = 0;
            transform.rotation = Quaternion.LookRotation(moveDir);
        }
    }
    protected virtual void UpdateAttack()
    {
        m_playerShoot.Attack();
    }
    protected virtual void UpdateAnim()
    {
        if (m_playerMovement == null) return;

        switch (Dir)
        {
            case MoveDir.Up:
                m_playerMovement.PlayAnim(new Vector2(0, 1));
                Debug.Log("Move Up");
                break;
            case MoveDir.Down:
                m_playerMovement.PlayAnim(new Vector2(0, -1));
                Debug.Log("Move Down");
                break;
            case MoveDir.Left:
                m_playerMovement.PlayAnim(new Vector2(-1, 0));
                Debug.Log("Move Left");
                break;
            case MoveDir.Right:
                m_playerMovement.PlayAnim(new Vector2(1, 0));
                Debug.Log("Move Right");
                break;
            default:
                m_playerMovement.PlayAnim(Vector2.zero);
                Debug.Log("Move None");
                break;
        }
    }

    protected virtual void Update()
    {
        UpdateMovement();
        UpdateRotation();
    }
}
