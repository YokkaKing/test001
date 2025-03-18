using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    public GameObject TOUCH1; // �\���E��\����؂�ւ������I�u�W�F�N�g1
    public GameObject TOUCH2; // �\���E��\����؂�ւ������I�u�W�F�N�g2

    public bool action = false;


    void Start()
    {
        TOUCH1.gameObject.SetActive(true); // TOUCH1��\��
        TOUCH2.gameObject.SetActive(false); // TOUCH2���\��
    }


    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // �}�E�X�̃��[���h���W

        // ���N���b�N���������u��
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero); // �}�E�X����ray�𔭎�

            if (hit.collider != null)
            {
                // �q�b�g�����I�u�W�F�N�g��touch1�̃^�O�������Ă��ā@���@TOUCH1�ɐݒ肳��Ă���I�u�W�F�N�g�@���@TOUCH2����\���Ȃ�
                if (hit.collider.CompareTag("touch1") && hit.collider.gameObject == TOUCH1.gameObject && TOUCH2.activeSelf == false)
                {
                    TOUCH1.gameObject.SetActive(false); // TOUCH1���\������
                    TOUCH2.gameObject.SetActive(true); // TOUCH2��\������

                    if (action) // action��true�Ȃ�
                    {
                        VarScripts.ACTION = true; // ACTION��true�ɂ���
                    }

                }// �q�b�g�����I�u�W�F�N�g��touch2�̃^�O�������Ă��ā@���@TOUCH2�ɐݒ肳��Ă���I�u�W�F�N�g�@���@TOUCH1����\���Ȃ�
                else if (hit.collider.CompareTag("touch2") && hit.collider.gameObject == TOUCH2.gameObject && TOUCH1.activeSelf == false)
                {
                    TOUCH1.gameObject.SetActive(true); // TOUCH1��\������
                    TOUCH2.gameObject.SetActive(false); // TOUCH2���\������
                }
            }
        }
    }
}
