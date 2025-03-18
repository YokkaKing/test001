using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeScene : MonoBehaviour {
    public static string NextSceneName;

    public void LoadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    public void ReloadScene() {
        string currentSceneName = SceneManager.GetActiveScene().name;
        StartCoroutine(UnloadResultSceneAndReload(currentSceneName));
    }
    private IEnumerator UnloadResultSceneAndReload(string sceneName) {
        // ResultScene���A�����[�h
        AsyncOperation unloadOperation = SceneManager.UnloadSceneAsync("ResultScene");
        while (!unloadOperation.isDone) {
            yield return null;
        }

        // ���݂̃V�[�����ēǂݍ���
        SceneManager.LoadScene(sceneName);
    }
}