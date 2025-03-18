using UnityEngine;

public class MoveSubCameraScript : MonoBehaviour
{
    public string tagName = "SubCamera"; // タグ名を指定
    private GameObject[] subCameraObjects;

    void Start() {
        // タグを使ってすべてのオブジェクトを取得
        subCameraObjects = GameObject.FindGameObjectsWithTag(tagName);
    }

    void Update() {
        // マウスのワールド座標を取得
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Camera.main.nearClipPlane; // カメラのクリップ平面を考慮
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // X軸とY軸の範囲を制限
        worldPosition.x = Mathf.Clamp(worldPosition.x, -6.1f, 6.1f);
        worldPosition.y = Mathf.Clamp(worldPosition.y, -3.2f, 3.2f);

        // すべてのサブカメラオブジェクトをマウスの位置に移動
        for (int i = 0; i < subCameraObjects.Length; i++) {
            Vector3 newPosition = new Vector3(worldPosition.x, worldPosition.y, subCameraObjects[i].transform.position.z);
            subCameraObjects[i].transform.position = newPosition;
        }
    }
}
