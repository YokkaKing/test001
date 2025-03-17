using UnityEngine;

public class MouseController2 : MonoBehaviour
{
    private bool isDragging = false; // �h���b�O�����ǂ���
    private Vector2 offset; // �}�E�X�ƃI�u�W�F�N�g�̋����̍���

    private Vector2 startPosition; // �����ʒu��ۑ�����ϐ�
    Vector2 currentPosition; // ���݂̈ʒu���擾


    void Start()
    {
        startPosition = transform.position; // �����ʒu���擾
    }


    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // �}�E�X�̃��[���h���W

        currentPosition = transform.position; // ��Ɍ��݂̈ʒu���擾

        if (Input.GetMouseButtonDown(0)) // ���N���b�N���������u��
        {
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero); // �}�E�X����ray�𔭎�

            if (hit.collider != null && hit.collider.CompareTag("object")) // �N���b�N�����I�u�W�F�N�g���������g�Ȃ�
            {
                isDragging = true; // �h���b�O��
                offset = (Vector2)transform.position - mousePosition; // �N���b�N�ʒu�Ƃ̍������擾
            }
        }

        if (Input.GetMouseButton(0) && isDragging) // ���N���b�N�����������Ă����
        {
            transform.position = mousePosition + offset; // �}�E�X�̈ʒu�ɒǏ]
        }

        if (Input.GetMouseButtonUp(0)) // ���N���b�N�𗣂����Ƃ�
        {
            isDragging = false; // �h���b�O���~

            if (CompareTag("object") && currentPosition != startPosition) // �����̃^�O��object�������ʒu����Ȃ����
            {
                // ResetPosition(); // �����ʒu�ɖ߂�
            }
        }
    }


    void ResetPosition() // �����ʒu�ɖ߂�֐�
    {
        transform.position = startPosition; // �����ʒu�ɖ߂�
    }
}
