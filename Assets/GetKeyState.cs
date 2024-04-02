using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyState : MonoBehaviour
{
    private bool isGetKey = false; //ÅöÇ±ÇÃçsÇí«â¡
    int keyCount = 0;
    public AudioSource audioSource;
    public AudioSource audioSource2;
    void Start()
    {
        keyCount = 0;
    }
    void Update()
    {

    }
    //âΩÇ©Ç…êGÇÍÇΩÇ∆Ç´
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            isGetKey = true;
            keyCount++;
            audioSource.Play();
        }
        if (keyCount == 2)
        {
            GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("LockWall");
            foreach (GameObject obj in objectsWithTag)
            {
                Destroy(obj);
                audioSource2.Play();
            }

        }
        if (keyCount == 4)
        {
            GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("LockWall2");
            foreach (GameObject obj in objectsWithTag)
            {
                Destroy(obj);
                audioSource2.Play();
            }

        }
        if (keyCount == 6)
        {
            GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("LockWall3");
            foreach (GameObject obj in objectsWithTag)
            {
                Destroy(obj);
                audioSource2.Play();
            }

        }
    }
}
    


