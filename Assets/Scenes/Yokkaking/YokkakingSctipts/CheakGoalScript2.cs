using UnityEngine;
using UnityEngine.SceneManagement;

public class CheakGoalScript2 : MonoBehaviour
{
    public string tag1 = "test1"; // チェックするタグ1
    public string tag2 = "test2"; // チェックするタグ2
    public string nextScene = "test"; // チェックするタグ2

    private GameObject subCameraObject;
    private SubCameraScript subCameraScript; // 他のScriptへの参照

    public AudioClip ShutterSound;
    private AudioSource audioSource;

    void Start() {
        // サブカメラオブジェクトを取得
        subCameraObject = GameObject.FindGameObjectWithTag("SubCamera");

        audioSource = gameObject.AddComponent<AudioSource>();
        // SubCameraScriptコンポーネントを持つオブジェクトを検索して取得
        subCameraScript = FindObjectOfType<SubCameraScript>();
    }

    void Update() {
        if (!SubCameraScript.isSubCameraActive) {
            if (Input.GetMouseButtonDown(1)) // 右クリックで
{
                audioSource.clip = ShutterSound;
                audioSource.Play();

                if (subCameraObject == null) {
                    Debug.Log("ERROR");
                }

                if (subCameraObject != null) {
                    bool tag1Overlapping = IsTagOverlapping(tag1); // tag1が重なっているかチェックするで
                    bool tag2Overlapping = IsTagOverlapping(tag2); // tag2が重なっているかチェックするんや
                    if (tag1Overlapping && tag2Overlapping && VarScripts.ACTION && VarScripts.ACTION2) { // 両方のタグが重なっているか確認するで
                        Debug.Log("clear!");
                        subCameraScript.SetSubCameraObjectsActive();
                        SceneManager.LoadSceneAsync("ResultScene", LoadSceneMode.Additive);  // リザルトシーンに移動
                    }
                }
            }
        }
    }

    bool IsTagOverlapping(string tag) {
        // 指定されたタグを持つオブジェクトがサブカメラオブジェクトと重なっているかチェックするで
        GameObject objectsWithTag = GameObject.FindGameObjectWithTag(tag);
        if (IsOverlapping(subCameraObject, objectsWithTag)) { // 重なっているか確認するで
            return true;
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
