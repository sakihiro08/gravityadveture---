using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyState2 : MonoBehaviour
{
    private bool isGetKey = false; //★この行を追加
    int keyCount2 = 0;
    public AudioSource audioSource;
    public AudioSource audioSource2;
    void Start()
    {
        keyCount2 = 0;
    }
    void Update()
    {

    }
    //何かに触れたとき
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Key2"))
        {
            isGetKey = true;
            keyCount2++;
            audioSource.Play();
        }
        if (keyCount2 == 4)
        {
            GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("LockWall2");
            foreach (GameObject obj in objectsWithTag)
            {
                Destroy(obj);
                audioSource2.Play();
            }
        }
    }

}
