using UnityEngine;

public class BGM : MonoBehaviour
{
    private static BGM instance;
    private AudioSource audioSource;

    public AudioClip bgmClip; // BGM�̉���

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject); // ���łɑ��݂���ꍇ�͐V�������̂��폜
            return;
        }

        // �C���X�^���X��ێ�
        instance = this;
        DontDestroyOnLoad(gameObject);

        // AudioSource��ǉ�
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = bgmClip;
        audioSource.loop = true; // ���[�v�Đ�
        audioSource.Play();
    }
}
