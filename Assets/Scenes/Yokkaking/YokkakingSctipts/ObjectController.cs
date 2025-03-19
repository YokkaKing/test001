using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public AudioClip ShutterSound; // ����炷���
    private AudioSource audioSource;


    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
    }


    void Update()
    {
        if (VarScripts.isDragging == false) // �h���b�O���Ă��Ȃ�������
        {
            if (CompareTag("OBJECT")) // ���g�̃^�O��OBJECT��������
            {
                audioSource.clip = ShutterSound; // ����炷
                audioSource.Play(); // ����炷

                VarScripts.ACTION = true; // �A�N�V�������I��

                Destroy(gameObject); // ���̃I�u�W�F�N�g������
            }
            else if (CompareTag("object")) // ���g�̃^�O��object��������
            {
                VarScripts.ACTION = false; // �A�N�V�������I�t
            }
        }

        Debug.Log(VarScripts.ACTION);
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Action")) // Action�̃^�O�ɓ���������
        {
            if (CompareTag("object")) // ���̃I�u�W�F�N�g�̃^�O��objcet��������
            {
                gameObject.tag = "OBJECT"; // �^�O��OBJECT�ɕύX
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Action")) // Action�̃^�O���痣�ꂽ��
        {
            if (CompareTag("OBJECT")) // ���̃I�u�W�F�N�g�̃^�O��OBJECT��������
            {
                gameObject.tag = "object"; // �^�O��object�ɖ߂�
            }
        }
    }
}