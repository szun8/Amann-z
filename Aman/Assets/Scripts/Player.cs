using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Vector3 dir = Vector3.zero;

    [SerializeField] private float moveSpeed;

    Rigidbody rigid;
    Collider coll;
    Animator anim;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        coll = GetComponent<Collider>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (dir != Vector3.zero)
        {
            rigid.MovePosition(transform.position + dir * Time.deltaTime * moveSpeed);
        }
    }

    public void OnMove(InputAction.CallbackContext state)
    {
        dir = state.ReadValue<Vector3>();
    }
}
