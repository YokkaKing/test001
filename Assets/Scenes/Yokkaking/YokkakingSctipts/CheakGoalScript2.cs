using UnityEngine;
using UnityEngine.SceneManagement;

public class CheakGoalScript2 : MonoBehaviour
{
    public string tag1 = "test1"; // �`�F�b�N����^�O1
    public string tag2 = "test2"; // �`�F�b�N����^�O2
    public string nextScene = "test"; // �`�F�b�N����^�O2

    private GameObject subCameraObject;
    private SubCameraScript subCameraScript; // ����Script�ւ̎Q��

    public AudioClip ShutterSound;
    private AudioSource audioSource;

    void Start() {
        // �T�u�J�����I�u�W�F�N�g���擾
        subCameraObject = GameObject.FindGameObjectWithTag("SubCamera");

        audioSource = gameObject.AddComponent<AudioSource>();
        // SubCameraScript�R���|�[�l���g�����I�u�W�F�N�g���������Ď擾
        subCameraScript = FindObjectOfType<SubCameraScript>();
    }

    void Update() {
        if (!SubCameraScript.isSubCameraActive) {
            if (Input.GetMouseButtonDown(1)) // �E�N���b�N��
{
                audioSource.clip = ShutterSound;
                audioSource.Play();

                if (subCameraObject == null) {
                    Debug.Log("ERROR");
                }

                if (subCameraObject != null) {
                    bool tag1Overlapping = IsTagOverlapping(tag1); // tag1���d�Ȃ��Ă��邩�`�F�b�N�����
                    bool tag2Overlapping = IsTagOverlapping(tag2); // tag2���d�Ȃ��Ă��邩�`�F�b�N������
                    if (tag1Overlapping && tag2Overlapping && VarScripts.ACTION && VarScripts.ACTION2) { // �����̃^�O���d�Ȃ��Ă��邩�m�F�����
                        Debug.Log("clear!");
                        subCameraScript.SetSubCameraObjectsActive();
                        SceneManager.LoadSceneAsync("ResultScene", LoadSceneMode.Additive);  // ���U���g�V�[���Ɉړ�
                    }
                }
            }
        }
    }

    bool IsTagOverlapping(string tag) {
        // �w�肳�ꂽ�^�O�����I�u�W�F�N�g���T�u�J�����I�u�W�F�N�g�Əd�Ȃ��Ă��邩�`�F�b�N�����
        GameObject objectsWithTag = GameObject.FindGameObjectWithTag(tag);
        if (IsOverlapping(subCameraObject, objectsWithTag)) { // �d�Ȃ��Ă��邩�m�F�����
            return true;
        }
        return false;
    }

    bool IsOverlapping(GameObject obj1, GameObject obj2) {
        // �R���C�_�[�d�Ȃ��Ă��邩����������������
        Collider2D collider1 = obj1.GetComponent<Collider2D>();
        Collider2D collider2 = obj2.GetComponent<Collider2D>();

        if (collider1 != null && collider2 != null) { // �����̃R���C�_�[�����݂��邩�m�F������
            // �R���C�_�[�̒��S���v�Z������
            Vector2 center1 = collider1.bounds.center;
            Vector2 center2 = collider2.bounds.center;

            // ���S���d�Ȃ��Ă��邩�`�F�b�N����l
            return collider1.bounds.Contains(center2) || collider2.bounds.Contains(center1);
        }

        return false;
    }
}
