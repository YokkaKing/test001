using Unity.VisualScripting;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // ���N���b�N
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // �}�E�X���W�����[���h���W�ɕϊ�
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero); // �N���b�N�ʒu�Ƀ��C���΂�

            if (hit.collider != null && hit.collider.CompareTag("object")) // �^�O�� "object" �Ȃ�
            {
                OnClick(hit.collider.gameObject); // �N���b�N���ꂽ�I�u�W�F�N�g��n��
            }
            else if (hit.collider == null)
            {
                OnClick(null);
            }
        }
    }

    void OnClick(GameObject clickedObject) // ���N���b�N���ꂽ��
    {
        if (clickedObject != null)
        {
            Debug.Log(clickedObject.name + " ���N���b�N���ꂽ�I�i�^�O: object�j"); // �N���b�N���ꂽ�I�u�W�F�N�g�̖��O���f�o�b�N����
        }
        else
        {
            Debug.Log("�N���b�N�����؂����I�I�I");
        }
    }
}