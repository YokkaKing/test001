using UnityEngine;

public class EXPROJONSCRIPT : MonoBehaviour {
    private GameObject nextstage;
    private GameObject clear;

    private CheakGoalScript cheakGoalScript; // ����Script�ւ̎Q��
    private CheakGoalScript2 cheakGoalScript2; // ����Script�ւ̎Q��

    void Start() {
        // �^�O���g���Ă��ׂĂ̑Ή�����I�u�W�F�N�g���擾
        nextstage = GameObject.FindGameObjectWithTag("NEXTSTAGE");
        clear = GameObject.FindGameObjectWithTag("CLEAR");

        cheakGoalScript = FindObjectOfType<CheakGoalScript>();
        cheakGoalScript2 = FindObjectOfType<CheakGoalScript2>();

        if (clear != null) {
            clear.SetActive(false);
        }
        else {
            Debug.LogError("CLEAR�^�O�̃I�u�W�F�N�g��������܂���ł����B");
        }
    }

    void Update() {
        if (cheakGoalScript == null) {
            // CheakGoalScript���܂��������Ă��Ȃ��ꍇ�A�ēx���������݂�
            cheakGoalScript = FindObjectOfType<CheakGoalScript>();
        }

        if (cheakGoalScript2 == null) {
            // CheakGoalScript2���܂��������Ă��Ȃ��ꍇ�A�ēx���������݂�
            cheakGoalScript2 = FindObjectOfType<CheakGoalScript2>();
        }

        if (cheakGoalScript != null && cheakGoalScript.nextScene == "TitleScene") {
            PerformSpecificAction();
        }
        else if (cheakGoalScript2 != null && cheakGoalScript2.nextScene == "TitleScene") {
            PerformSpecificAction();
        }
    }

    void PerformSpecificAction() {
        // NEXTSTAGE�^�O�̃I�u�W�F�N�g�𖳌���
        if (nextstage != null) {
            nextstage.SetActive(false);
            Debug.Log("NEXTSTAGE�^�O�̃I�u�W�F�N�g�𖳌������܂����B");
        }
        else {
            Debug.LogError("NEXTSTAGE�^�O�̃I�u�W�F�N�g��������܂���ł����B");
        }

        // CLEAR�^�O�̃I�u�W�F�N�g��L����
        if (clear != null) {
            clear.SetActive(true);
            Debug.Log("CLEAR�^�O�̃I�u�W�F�N�g��L�������܂����B");
        }
        else {
            Debug.LogError("CLEAR�^�O�̃I�u�W�F�N�g��������܂���ł����B");
        }
    }
}