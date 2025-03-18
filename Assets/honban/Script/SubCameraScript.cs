using UnityEngine;

public class SubCameraScript : MonoBehaviour {
    private GameObject subCameraObject;
    public static bool isSubCameraActive;

    void Start() {
        // �^�O���g���Ă��ׂẴJ�����I�u�W�F�N�g���擾
        subCameraObject = GameObject.FindGameObjectWithTag("SubCamera");

        // �����ݒ�Ƃ��� SubCamera �𖳌��ɂ���
        isSubCameraActive = false;
        SetSubCameraObjectsActive();
    }

    public void SetSubCameraObjectsActive() {
        bool isActive = isSubCameraActive;
        isSubCameraActive = !isSubCameraActive;
        GameObject obj = subCameraObject;
        obj.SetActive(isActive);
    }
}
