using UnityEngine;

public class ShotScript : MonoBehaviour
{
    private Camera mainCamera;
    private Camera subCamera;
    private bool isSubCameraActive;

    void Start() {
        // �^�O���g���ăJ�������擾
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        subCamera = GameObject.FindGameObjectWithTag("SubCamera").GetComponent<Camera>();

        // �����ݒ�Ƃ���MainCamera��L���ɂ��ASubCamera�𖳌��ɂ���
        isSubCameraActive = false;
        mainCamera.gameObject.SetActive(!isSubCameraActive);
        subCamera.gameObject.SetActive(isSubCameraActive);
    }

    void Update() {
        // M�L�[�������ꂽ�Ƃ��ɃJ������؂�ւ���
        if (Input.GetKeyDown(KeyCode.M)) {
            isSubCameraActive = !isSubCameraActive;
            mainCamera.gameObject.SetActive(!isSubCameraActive);
            subCamera.gameObject.SetActive(isSubCameraActive);
        }
    }
}
