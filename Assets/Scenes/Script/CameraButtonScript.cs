using UnityEngine;

public class CameraButtonScript : MonoBehaviour {
    private SubCameraScript subCameraScript; // ����Script�ւ̎Q��

    void Start() {
        // SubCameraScript�R���|�[�l���g�����I�u�W�F�N�g���������Ď擾
        subCameraScript = FindObjectOfType<SubCameraScript>();
    }

    void OnMouseDown() {
        // �I�u�W�F�N�g���N���b�N���ꂽ�Ƃ��ɌĂяo�����
        Debug.Log("�I�u�W�F�N�g���N���b�N����܂���");

        if (subCameraScript != null) {
            subCameraScript.SetSubCameraObjectsActive();
            Debug.Log("SetSubCameraObjectsActive���Ăяo����܂���");
        } else {
            Debug.LogError("subCameraScript��������܂���ł���");
        }
    }
}