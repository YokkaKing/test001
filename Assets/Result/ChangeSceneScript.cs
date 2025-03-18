using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeSceneScript : MonoBehaviour {

    public CheakGoalScript cheakGoalScript;

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
        // ResultScene���A�����[�h
        AsyncOperation unloadOperation = SceneManager.UnloadSceneAsync("ResultScene");
        while (!unloadOperation.isDone) {
            yield return null;
        }

        // ���݂̃V�[�����ēǂݍ���
        SceneManager.LoadScene(sceneName);
    }
}