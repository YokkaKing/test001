using UnityEngine;
using UnityEngine.UI;

public class SubCameraScript : MonoBehaviour {
    private GameObject[] subCameraObjects;
    public bool isSubCameraActive;

    public Button toggleButton; // �{�^�����w��

    void Start() {
        // �^�O���g���Ă��ׂẴJ�����I�u�W�F�N�g���擾
        subCameraObjects = GameObject.FindGameObjectsWithTag("SubCamera");

        // �����ݒ�Ƃ��� SubCamera �𖳌��ɂ���
        isSubCameraActive = false;
        SetSubCameraObjectsActive();
    }

    public void SetSubCameraObjectsActive() {
        bool isActive = isSubCameraActive;
        isSubCameraActive = !isSubCameraActive;
        for (int i = 0; i < subCameraObjects.Length; i++) {
            GameObject obj = subCameraObjects[i];
            obj.SetActive(isActive);
        }
    }
}
