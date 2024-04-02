using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    private bool hasJumped = false;  // ジャンプしたかどうかの状態を管理
    private float DownForce;
    int graflag =1;
    public AudioSource audioSource;
    public AudioSource audioSource2;
    void Start()
    {
        DownForce = -300;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Physics.gravity = new Vector3(0, 9.81f, 0);
            graflag = 1;
            audioSource2.Play();
        }
        if (Input.GetKey(KeyCode.S))
        {
            Physics.gravity = new Vector3(0, -9.81f, 0);
            graflag = 0;
            audioSource2.Play();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && !hasJumped)
        {
            // ジャンプ
            rb.AddForce(new Vector3(0, DownForce, 0));
            // ジャンプした状態に設定
            hasJumped = true;
            audioSource.Play();
        }
    }
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
