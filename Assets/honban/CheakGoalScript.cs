using UnityEngine;

public class CheakGoalScript : MonoBehaviour
{
    public string subCameraTag = "SubCamera"; // サブカメラのタグ名
    public string tag1 = "test1"; // チェックするタグ1
    public string tag2 = "test2"; // チェックするタグ2

    private GameObject subCameraObject;

    public AudioClip ShutterSound;
    AudioSource audioSource;

    void Start() {
        // サブカメラオブジェクトを取得
        subCameraObject = GameObject.FindGameObjectWithTag(subCameraTag);

        audioSource = gameObject.AddComponent<AudioSource>();
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) // 右クリックで
        {
            audioSource.clip = ShutterSound;
            audioSource.Play();

            if (subCameraObject != null) {
                bool tag1Overlapping = IsTagOverlapping(tag1); // tag1が重なっているかチェックするで
                bool tag2Overlapping = IsTagOverlapping(tag2); // tag2が重なっているかチェックするんや

                if (tag1Overlapping && tag2Overlapping) { // 両方のタグが重なっているか確認するで
                    Debug.Log("クリア！");  // 後でクリア処理
                }
            }
        }
    }

    bool IsTagOverlapping(string tag) {
        // 指定されたタグを持つオブジェクトがサブカメラオブジェクトと重なっているかチェックするで
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tag);
        for (int i = 0; i < objectsWithTag.Length; i++) { // forループでチェックするよん
            if (IsOverlapping(subCameraObject, objectsWithTag[i])) { // 重なっているか確認するで
                return true;
            }
        }
        return false;
    }

    bool IsOverlapping(GameObject obj1, GameObject obj2) {
        // コライダー重なっているかちぇっっっっっく
        Collider2D collider1 = obj1.GetComponent<Collider2D>();
        Collider2D collider2 = obj2.GetComponent<Collider2D>();

        if (collider1 != null && collider2 != null) { // 両方のコライダーが存在するか確認するよん
            // コライダーの中心を計算するよん
            Vector2 center1 = collider1.bounds.center;
            Vector2 center2 = collider2.bounds.center;

            // 中心が重なっているかチェックする四
            return collider1.bounds.Contains(center2) || collider2.bounds.Contains(center1);
        }

        return false;
    }
}
