using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Animator animator;
    Quaternion targetRotation;

    //　キャラクターの速度
    private Vector3 velocity;
    //　キャラクターの歩くスピード
    [SerializeField]
    private float walkSpeed = 2f;
    //　キャラクターの走るスピード
    [SerializeField]
    private float runSpeed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        targetRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        // 入力ベクトルの取得
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var speed = Input.GetKey(KeyCode.LeftShift) ? 2 : 1;
        var rotationSpeed = 600 * Time.deltaTime;

        var input = new Vector3(horizontal, 0, vertical).normalized;

        //移動方向を向く
        if(input.magnitude>0.5f)
        {
            transform.rotation = Quaternion.LookRotation(input, Vector3.up);
        }
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed);

        // 移動速度をアニメーターに反映
        animator.SetFloat("Speed", input.magnitude*speed,0.1f,Time.deltaTime);
    }
}
