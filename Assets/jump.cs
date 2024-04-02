using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    Rigidbody rb;
    private float upForce;
    private bool hasJumped = false;  // �W�����v�������ǂ����̏�Ԃ��Ǘ�
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
        
        // �W�����v
        rb.AddForce(new Vector3(0, upForce, 0));
        // �W�����v������Ԃɐݒ�
        hasJumped = true;
    }
    // OnCollisionEnter���g�p���Ē��n���ɃW�����v��Ԃ����Z�b�g
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