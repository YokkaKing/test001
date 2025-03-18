using UnityEngine;
using UnityEngine.EventSystems;

public class EventSystemScript : MonoBehaviour {
    void Awake() {
        // �V�[�����̂��ׂĂ�EventSystem���擾
        EventSystem[] eventSystems = FindObjectsOfType<EventSystem>();

        if (eventSystems.Length == 0) {
            // EventSystem�����݂��Ȃ��ꍇ�A�V����EventSystem��ǉ�
            GameObject eventSystem = new GameObject("EventSystem");
            eventSystem.AddComponent<EventSystem>();
            eventSystem.AddComponent<StandaloneInputModule>();
        }
        else if (eventSystems.Length > 1) {
            // ������EventSystem�����݂���ꍇ�A�ǉ���EventSystem���폜�܂��͖�����
            for (int i = 1; i < eventSystems.Length; i++) {
                Destroy(eventSystems[i].gameObject);
            }
        }
    }
}