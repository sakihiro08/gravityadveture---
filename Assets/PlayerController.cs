using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // �f�t�H���g�̉摜(���e�̉摜)
    public Sprite defaultImage;
    // �摜�`��p�̃R���|�[�l���g
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        // Sprite��SpriteRenderer�R���|�[�l���g���擾
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {   //�v���C���[�̃��[���h���W
        Vector3 pos = transform.position;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += 0.05f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= 0.05f;
        }
        transform.position = new Vector3(pos.x, pos.y, pos.z);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Key2"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Key3"))
        {
            Destroy(other.gameObject);
        }   
        if (other.gameObject.CompareTag("next"))
            {
                SceneManager.LoadScene("Main stage");
            }
        if (other.gameObject.CompareTag("Goal"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Goal");
        }
        if (other.collider.tag == "explanation")
        {
            // �f�t�H���g�̉摜�𔚔���̉摜�ɐ؂�ւ���
            sr.sprite = defaultImage;
        }
    }
   
    }
