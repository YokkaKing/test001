using UnityEngine;

public class ShotScript : MonoBehaviour
{
    private Camera mainCamera;
    private Camera subCamera;
    private bool isSubCameraActive;

    void Start() {
        // タグを使ってカメラを取得
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        subCamera = GameObject.FindGameObjectWithTag("SubCamera").GetComponent<Camera>();

        // 初期設定としてMainCameraを有効にし、SubCameraを無効にする
        isSubCameraActive = false;
        mainCamera.gameObject.SetActive(!isSubCameraActive);
        subCamera.gameObject.SetActive(isSubCameraActive);
    }

    void Update() {
        // Mキーが押されたときにカメラを切り替える
        if (Input.GetKeyDown(KeyCode.M)) {
            isSubCameraActive = !isSubCameraActive;
            mainCamera.gameObject.SetActive(!isSubCameraActive);
            subCamera.gameObject.SetActive(isSubCameraActive);
        }
    }
}
