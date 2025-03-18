using UnityEngine;

public class CameraController : MonoBehaviour
{
    public bool cameraOn;

    private SubCameraScript subCameraScript; // ����Script�ւ̎Q��

    void Start()
    {
        // SubCameraScript�R���|�[�l���g�����I�u�W�F�N�g���������Ď擾
        subCameraScript = FindObjectOfType<SubCameraScript>();

        cameraOn = false;
    }

    public void ConecctSetSubCameraObjectsActive()
    {
        subCameraScript.SetSubCameraObjectsActive();
    }

    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // �}�E�X�̃��[���h���W

        // ���N���b�N���������u��
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero); // �}�E�X����ray�𔭎�

            if (hit.collider.CompareTag("camera") && cameraOn == false) // �G�����I�u�W�F�N�g��camera�@���@cameraOn��true�Ȃ�
            {
                subCameraScript.SetSubCameraObjectsActive(); // �A�N�e�B�u
            }
            else if (hit.collider.CompareTag("camera") && cameraOn)
            {
                subCameraScript.SetSubCameraObjectsActive(); // �A�N�e�B�u
            }
        }
    }
}