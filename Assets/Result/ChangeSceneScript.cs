using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeScene : MonoBehaviour {

    public CheakGoalScript cheakGoalScript;

    void Start () {
        // CheakGoalScriptを持つオブジェクトを探して参照
        cheakGoalScript = FindObjectOfType<CheakGoalScript>();
    }

    public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    public void ReloadScene() {
        string currentSceneName = SceneManager.GetActiveScene().name;
        StartCoroutine(UnloadResultSceneAndReload(currentSceneName));
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