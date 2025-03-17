using UnityEngine;

public class SubCameraScript : MonoBehaviour {
    private GameObject[] subCameraObjects;
    public bool isSubCameraActive;

    void Start() {
        // �^�O���g���Ă��ׂẴJ�����I�u�W�F�N�g���擾
        subCameraObjects = GameObject.FindGameObjectsWithTag("SubCamera");

        // �����ݒ�Ƃ��� SubCamera �𖳌��ɂ���
        isSubCameraActive = false;
        SetSubCameraObjectsActive(isSubCameraActive);
    }

    void Update() {
        // M�L�[�������ꂽ�Ƃ��ɃJ������؂�ւ���
        if (Input.GetKeyDown(KeyCode.M)) {
            isSubCameraActive = !isSubCameraActive;
            SetSubCameraObjectsActive(isSubCameraActive);
        }
    }

    private void SetSubCameraObjectsActive(bool isActive) {
        for (int i = 0; i < subCameraObjects.Length; i++) {
            GameObject obj = subCameraObjects[i];
            obj.SetActive(isActive);
        }
    }
}
