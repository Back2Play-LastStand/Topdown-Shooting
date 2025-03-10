using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, IPlayerMovement, IPlayerAnim
{
    [SerializeField]
    private float m_speed;
    private Rigidbody m_rigid;

    private Animator m_anim;
    public Animator Anim => m_anim;

    private void Awake()
    {
        m_rigid = GetComponent<Rigidbody>();
        m_anim = GetComponent<Animator>();
    }

    public void Move(Vector2 inputVec)
    {
        Ray ray = Camera.main.ScreenPointToRay(inputVec);
        Plane groundPlane = new Plane(Vector3.up, transform.position);

        if (groundPlane.Raycast(ray, out float enter))
        {
            Vector3 hitPoint = ray.GetPoint(enter);
            Vector3 mouseDirection = (hitPoint - transform.position).normalized;

            mouseDirection.y = 0;
            Vector3 right = Vector3.Cross(Vector3.up, mouseDirection);
            Vector3 moveVec = (mouseDirection * inputVec.y + right * inputVec.x).normalized;

            transform.position += moveVec * m_speed * Time.deltaTime;
        }
    }

    public void MoveTo(Vector3 des)
    {
        // TODO
    }

    public void LookAtMouse(Vector2 inputMousePos)
    {
        Ray ray = Camera.main.ScreenPointToRay(inputMousePos);
        Plane groundPlane = new Plane(Vector3.up, transform.position);  

        if (groundPlane.Raycast(ray, out float enter))
        {
            Vector3 hitPoint = ray.GetPoint(enter);
            Vector3 direction = (hitPoint - transform.position).normalized;

            direction.y = 0;

            if (direction != Vector3.zero)
            {
                Quaternion targetRotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 10f * Time.deltaTime);
            }
        }
    }

    public void PlayAnim(Vector2 inputVec)
    {
        m_anim.SetFloat("Forward", inputVec.y);
        m_anim.SetFloat("Turn", inputVec.x);
    }
}
