using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public GameObject soundPrefab; // �@�ō쐬�����I�u�W�F�N�g��Prefab

    void Update()
    {
        if (VarScripts.isDragging == false) // �h���b�O���Ă��Ȃ�������
        {
            if (CompareTag("OBJECT")) // ���g�̃^�O��OBJECT��������
            {
                VarScripts.ACTION = true; // �A�N�V�������I��

                Instantiate(soundPrefab, transform.position, Quaternion.identity);

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