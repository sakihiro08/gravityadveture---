using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bombController : MonoBehaviour
{
    // �f�t�H���g�̉摜(���e�̉摜)
    public Sprite defaultImage;
    // �摜�`��p�̃R���|�[�l���g
    SpriteRenderer sr;

    void Start()
    {
        // Sprite��SpriteRenderer�R���|�[�l���g���擾
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Player�^�O�������I�u�W�F�N�g�ƏՓ˂������ɏ���
    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.tag == "explanation")
        {
            // �f�t�H���g�̉摜�𔚔���̉摜�ɐ؂�ւ���
            sr.sprite = defaultImage;
        }
    }
}