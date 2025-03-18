using UnityEngine;

public class CameraButtonScript : MonoBehaviour {
    private SubCameraScript subCameraScript; // 他のScriptへの参照

    void Start() {
        // SubCameraScriptコンポーネントを持つオブジェクトを検索して取得
        subCameraScript = FindObjectOfType<SubCameraScript>();
    }

    void OnMouseDown() {
        // オブジェクトがクリックされたときに呼び出される
        if (subCameraScript != null) {
            subCameraScript.SetSubCameraObjectsActive();
        }
    }
}