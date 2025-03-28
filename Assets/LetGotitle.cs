using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LetGotitle : MonoBehaviour {
    void Start() {
        StartCoroutine(GoToTitleScene());
    }

    void Update() {

    }

    IEnumerator GoToTitleScene() {
        yield return new WaitForSeconds(1);  // 1秒待機
        SceneManager.LoadScene("TitleScene");  // TitleSceneに移動
        Destroy(this);
    }
}