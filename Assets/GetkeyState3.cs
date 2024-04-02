using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetkeyState3 : MonoBehaviour
{
    private bool isGetKey = false; //ÅöÇ±ÇÃçsÇí«â¡
    int keyCount3 = 0;
    public AudioSource audioSource;
    public AudioSource audioSource2;
    void Start()
    {
        keyCount3 = 0;
    }
    void Update()
    {

    }
    //âΩÇ©Ç…êGÇÍÇΩÇ∆Ç´
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Key3"))
        {
            isGetKey = true;
            keyCount3++;
            audioSource.Play();
        }
        if (keyCount3 == 2)
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
