using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{

    public static bool ACTION = false;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Action")) // Action�̃^�O�ɓ���������
        {
            if (CompareTag("object")) // ���̃I�u�W�F�N�g�̃^�O��objcet��������
            {
                gameObject.tag = "OBJECT"; // �^�O��OBJECT�ɕύX
                ACTION = true;
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
                ACTION = false;
            }
        }
    }
}