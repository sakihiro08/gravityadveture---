using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UPCollision : MonoBehaviour
{

    public GameObject floorPrefab; // ����Prefab��Inspector����A�T�C������
    // Start is called before the first frame update
    void Start()
    {
        // �v���C���[�I�u�W�F�N�g�̏��Ƃ��Ă�Prefab�̃C���X�^���X���Ɛe�̐ݒ�
        GameObject instantiatedFloor = Instantiate(floorPrefab, transform.position, Quaternion.identity);
        transform.SetParent(instantiatedFloor.transform);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        // �c�����̃g���K�[�C�x���g�����o
        if (col.tag == "floor")
        {
            //// �v���C���[�I�u�W�F�N�g�����I�u�W�F�N�g�̎q�ɐݒ�
            this.gameObject.transform.SetParent(floorPrefab.gameObject.transform);
        }
    }

    void OnTriggerExit(Collider col)
    {
        // �c�����̃g���K�[�C�x���g�����o
        if (col.tag == "floor")
        {
            // �v���C���[�I�u�W�F�N�g�Ə��I�u�W�F�N�g�̐e�q�֌W������
            this.gameObject.transform.SetParent(null);
        }
    }
}
