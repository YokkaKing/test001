using UnityEngine;
using UnityEngine.UI;

public class SubCameraScript : MonoBehaviour {
    private GameObject[] subCameraObjects;
    public bool isSubCameraActive;

    public Button toggleButton; // ボタンを指定

    void Start() {
        // タグを使ってすべてのカメラオブジェクトを取得
        subCameraObjects = GameObject.FindGameObjectsWithTag("SubCamera");

        // 初期設定として SubCamera を無効にする
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
