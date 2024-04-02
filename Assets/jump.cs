using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    Rigidbody rb;
    private float upForce;
    private bool hasJumped = false;  // ジャンプしたかどうかの状態を管理
    public AudioSource audioSource;
    void Start()
    {
        upForce = 350;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)&&!hasJumped)
        {
            JumpAction();
            audioSource.Play();
        }
    
    }
    void JumpAction()
    {
        
        // ジャンプ
        rb.AddForce(new Vector3(0, upForce, 0));
        // ジャンプした状態に設定
        hasJumped = true;
    }
    // OnCollisionEnterを使用して着地時にジャンプ状態をリセット
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            hasJumped = false;
        }
        if (collision.gameObject.CompareTag("stair"))
        {
            hasJumped = false;
        }
    }
}