using UnityEngine;
using UnityEngine.SceneManagement;

public class sound2 : MonoBehaviour
{
    public AudioClip sound; // �Đ����鉹
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = sound;
        audioSource.Play();

        // ���̒����ɉ����ăI�u�W�F�N�g���폜
        Destroy(gameObject, sound.length);
    }
}