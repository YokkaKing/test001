using UnityEngine;
using System.Collections;

public class SoundSwitch : MonoBehaviour {
    public GameObject soundPrefab; // �@�ō쐬�����I�u�W�F�N�g��Prefab

    void OnMouseDown() {
        GameObject soundObject = Instantiate(soundPrefab, transform.position, Quaternion.identity);
        DontDestroyOnLoad(soundObject); // ���������I�u�W�F�N�g���V�[�����܂����ŕێ�

        AudioSource audioSource = soundObject.GetComponent<AudioSource>();
        if (audioSource != null) {
            StartCoroutine(CheckIfAudioFinished(audioSource, soundObject));
        }
        else {
            Debug.LogWarning("�����I�u�W�F�N�g��AudioSource���A�^�b�`����Ă��܂���B");
        }
    }

    private IEnumerator CheckIfAudioFinished(AudioSource audioSource, GameObject soundObject) {
        // �������Đ����ł������ҋ@
        while (audioSource.isPlaying) {
            yield return null;
        }

        // �����̍Đ����I��������I�u�W�F�N�g���폜
        Destroy(soundObject);
    }
}