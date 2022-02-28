using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController characterController;
    private Animator animator;
    //�@�L�����N�^�[�̑��x
    private Vector3 velocity;
    //�@�L�����N�^�[�̕����X�s�[�h
    [SerializeField]
    private float walkSpeed = 2f;
    //�@�L�����N�^�[�̑���X�s�[�h
    [SerializeField]
    private float runSpeed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (characterController.isGrounded)
        {
            velocity = Vector3.zero;

            var input = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

            if (input.magnitude > 0.3f)
            {
                transform.LookAt(transform.position + input.normalized);
                animator.SetFloat("Speed", input.magnitude);
                if (input.magnitude > 0.5f)
                {
                    velocity += transform.forward * runSpeed;
                }
                else
                {
                    velocity += transform.forward * walkSpeed;
                }
            }
            else
            {
                animator.SetFloat("Speed", 0f,0.1f,Time.deltaTime);
            }
        }

        velocity.y += Physics.gravity.y * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }
}