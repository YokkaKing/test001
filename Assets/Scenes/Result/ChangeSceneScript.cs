using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeSceneScript : MonoBehaviour {

    private CheakGoalScript cheakGoalScript;

    void Start() {
        // CheakGoalScriptを持つオブジェクトを探して参照
        cheakGoalScript = FindObjectOfType<CheakGoalScript>();
    }

    void OnMouseDown() {
        // 自分自身のタグが"ReStart"だったらシーンをロード
        if (gameObject.CompareTag("Reload")) {
            ReloadScene();
        } else if (gameObject.CompareTag("Next")) {
            NextScene();
        }
    }

    public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    public void ReloadScene() {
        string currentSceneName = SceneManager.GetActiveScene().name;
        StartCoroutine(UnloadResultSceneAndReload(currentSceneName));
        SceneManager.LoadScene(currentSceneName);
    }

    public void NextScene() {
        SceneManager.LoadScene(cheakGoalScript.nextScene);
    }

    private IEnumerator UnloadResultSceneAndReload(string sceneName) {
        // ResultSceneをアンロード
        AsyncOperation unloadOperation = SceneManager.UnloadSceneAsync("ResultScene");
        while (!unloadOperation.isDone) {
            yield return null;
        }

        // 現在のシーンを再読み込み
        SceneManager.LoadScene(sceneName);
    }
}