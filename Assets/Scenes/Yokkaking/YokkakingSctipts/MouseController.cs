using UnityEngine;

public class MouseController : MonoBehaviour
{
    private GameObject draggableObject; // ���݃h���b�O���̃I�u�W�F�N�g
    private Vector2 offset; // �}�E�X�ƃI�u�W�F�N�g�̋����̍���

    private Vector2 startPosition; // �����ʒu��ۑ�����ϐ�
    private Vector2 currentPosition; // ���݂̈ʒu���擾

    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // �}�E�X�̃��[���h���W
        currentPosition = draggableObject ? draggableObject.transform.position : Vector2.zero; // ���݂̈ʒu

        // ���N���b�N���������u��
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero); // �}�E�X����ray�𔭎�

            if (hit.collider != null && hit.collider.CompareTag("object")) // �N���b�N�����I�u�W�F�N�g��"object"�^�O��
            {
                draggableObject = hit.collider.gameObject; // �h���b�O�ΏۃI�u�W�F�N�g��ݒ�
                VarScripts.isDragging = true; // �h���b�O��
                offset = (Vector2)draggableObject.transform.position - mousePosition; // �N���b�N�ʒu�Ƃ̍������擾

                startPosition = hit.transform.position; // �����l�ʒu��G�ꂽ�I�u�W�F�N�g�ɐݒ�
            }
        }

        // ���N���b�N�����������Ă����
        if (Input.GetMouseButton(0) && VarScripts.isDragging && draggableObject != null)
        {
            draggableObject.transform.position = mousePosition + offset; // �}�E�X�̈ʒu�ɒǏ]
        }

        // ���N���b�N�𗣂����Ƃ�
        if (Input.GetMouseButtonUp(0))
        {
            if (VarScripts.isDragging && draggableObject != null)
            {
                VarScripts.isDragging = false; // �h���b�O���~

                if (draggableObject.CompareTag("object") && currentPosition != startPosition) // �����ʒu����Ȃ����
                {
                    ResetPosition(); // �����ʒu�ɖ߂�
                }
                draggableObject = null; // �h���b�O�ΏۃI�u�W�F�N�g�����Z�b�g
            }
        }
    }

    // �����ʒu�ɖ߂�֐�
    void ResetPosition()
    {
        if (draggableObject != null)
        {
            draggableObject.transform.position = startPosition; // �����ʒu�ɖ߂�
        }
    }
}
