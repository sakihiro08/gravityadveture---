using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject target;
    public float minX; // ������͈͂̍ŏ�x���W
    public float maxX; // ������͈͂̍ő�x���W
    public float minY; // ������͈͂̍ŏ�y���W
    public float maxY; // ������͈͂̍ő�y���W

    private void Update()
    {
        // �^�[�Q�b�g�̈ʒu���擾
        Vector3 targetPosition = target.transform.position;

        // X���W���͈͓��Ɏ��܂�悤�ɒ���
        float newX = Mathf.Clamp(targetPosition.x, minX, maxX);

        // Y���W���͈͓��Ɏ��܂�悤�ɒ���
        float newY = Mathf.Clamp(targetPosition.y, minY, maxY);

        // �J�����̈ʒu���X�V
        transform.position = new Vector3(newX, newY, transform.position.z);
    }
}
