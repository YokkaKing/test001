using UnityEngine;

public class ClickSoundScript : MonoBehaviour
{
    public AudioClip clickSound;  // �A�^�b�`����AudioClip

    private AudioSource audioSource;

    void Start() {
        // AudioSource�R���|�[�l���g��ǉ����AAudioClip��ݒ�
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    void OnMouseDown() {
        // �N���b�N�����Ƃ���AudioClip���Đ�
        Debug.Log("�ڂ��͍q��ǐ���");
        audioSource.clip = clickSound;
        audioSource.Play();
    }
}
