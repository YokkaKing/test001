using UnityEngine;

public class SoundSwitch : MonoBehaviour
{
    public GameObject soundPrefab; // ①で作成したオブジェクトのPrefab

    void OnMouseDown()
    {
        GameObject soundObject = Instantiate(soundPrefab, transform.position, Quaternion.identity);
        DontDestroyOnLoad(soundObject); // 生成したオブジェクトをシーンをまたいで保持
    }
}