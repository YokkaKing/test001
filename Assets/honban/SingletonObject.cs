using UnityEngine;

public class SingletonObject : MonoBehaviour {
    private static SingletonObject instance;

    void Awake() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);  // �V�[���ԂŃI�u�W�F�N�g��ێ�����
        }
        else {
            Destroy(gameObject);  // ���ɑ��݂���ꍇ�͐V�����I�u�W�F�N�g��j��
        }
    }
}