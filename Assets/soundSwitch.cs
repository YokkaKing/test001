using UnityEngine;

public class SoundSwitch : MonoBehaviour
{
    public GameObject soundPrefab; // �@�ō쐬�����I�u�W�F�N�g��Prefab

    void OnMouseDown()
    {
        GameObject soundObject = Instantiate(soundPrefab, transform.position, Quaternion.identity);
        DontDestroyOnLoad(soundObject); // ���������I�u�W�F�N�g���V�[�����܂����ŕێ�
    }
}