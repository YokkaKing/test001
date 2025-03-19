using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController2 : MonoBehaviour
{
    public GameObject TOUCH3; // �\���E��\����؂�ւ������I�u�W�F�N�g1
    public GameObject TOUCH4; // �\���E��\����؂�ւ������I�u�W�F�N�g2

    public bool action2 = false; // �����ݒ�

    public AudioClip ShutterSound; // ����炷���
    private AudioSource audioSource;


    void Start()
    {
        TOUCH3.gameObject.SetActive(true); // TOUCH1��\��
        TOUCH4.gameObject.SetActive(false); // TOUCH2���\��

        audioSource = gameObject.AddComponent<AudioSource>();
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
                // �q�b�g�����I�u�W�F�N�g��touch3�̃^�O�������Ă��ā@���@TOUCH3�ɐݒ肳��Ă���I�u�W�F�N�g�@���@TOUCH4����\���Ȃ�
                if (hit.collider.CompareTag("touch3") && hit.collider.gameObject == TOUCH3.gameObject && TOUCH4.activeSelf == false)
                {
                    TOUCH3.gameObject.SetActive(false); // TOUCH1���\������
                    TOUCH4.gameObject.SetActive(true); // TOUCH2��\������

                    audioSource.clip = ShutterSound; // ����炷
                    audioSource.Play(); // ����炷

                    if (action2) // action2��true�Ȃ�
                    {
                        VarScripts.ACTION2 = true; // ACTION��true�ɂ���
                    }

                }// �q�b�g�����I�u�W�F�N�g��touch4�̃^�O�������Ă��ā@���@TOUCH4�ɐݒ肳��Ă���I�u�W�F�N�g�@���@TOUCH3����\���Ȃ�
                else if (hit.collider.CompareTag("touch4") && hit.collider.gameObject == TOUCH4.gameObject && TOUCH3.activeSelf == false)
                {
                    TOUCH3.gameObject.SetActive(true); // TOUCH1��\������
                    TOUCH4.gameObject.SetActive(false); // TOUCH2���\������

                    audioSource.clip = ShutterSound; // ����炷
                    audioSource.Play(); // ����炷

                    if (action2)
                    {
                        VarScripts.ACTION2 = false; // ACTION��false�ɂ���
                    }
                }
            }
        }
    }
}