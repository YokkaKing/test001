using UnityEngine;

public class SingletonObject : MonoBehaviour {
    private static SingletonObject instance;

    void Awake() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);  // シーン間でオブジェクトを保持する
        }
        else {
            Destroy(gameObject);  // 既に存在する場合は新しいオブジェクトを破棄
        }
    }
}