using UnityEngine;

public class SubCameraScript : MonoBehaviour {
    private GameObject[] subCameraObjects;
    public bool isSubCameraActive;

    void Start() {
        // タグを使ってすべてのカメラオブジェクトを取得
        subCameraObjects = GameObject.FindGameObjectsWithTag("SubCamera");

        // 初期設定として SubCamera を無効にする
        isSubCameraActive = false;
        SetSubCameraObjectsActive(isSubCameraActive);
    }

    void Update() {
        // Mキーが押されたときにカメラを切り替える
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
