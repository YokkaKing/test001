using UnityEngine;

public class CameraButtonScript : MonoBehaviour
{
    private SubCameraScript subCameraScript; // OtherScriptへの参照

    void Start() {
        // SubCameraScriptコンポーネントを持つオブジェクトを検索して取得
        subCameraScript = FindObjectOfType<SubCameraScript>();
    }

    public void ConecctSetSubCameraObjectsActive() {
        subCameraScript.SetSubCameraObjectsActive();
    }
}
