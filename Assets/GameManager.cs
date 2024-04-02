using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Application targetFrameRate;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
        audioSource.Play();
    }
}
