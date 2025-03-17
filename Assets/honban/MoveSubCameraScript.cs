using UnityEngine;

public class MoveSubCameraScript : MonoBehaviour
{
    public string tagName = "SubCamera"; // �^�O�����w��
    private GameObject[] subCameraObjects;

    void Start() {
        // �^�O���g���Ă��ׂẴI�u�W�F�N�g���擾
        subCameraObjects = GameObject.FindGameObjectsWithTag(tagName);
    }

    void Update() {
        // �}�E�X�̃��[���h���W���擾
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Camera.main.nearClipPlane; // �J�����̃N���b�v���ʂ��l��
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // X����Y���͈̔͂𐧌�
        worldPosition.x = Mathf.Clamp(worldPosition.x, -6.1f, 6.1f);
        worldPosition.y = Mathf.Clamp(worldPosition.y, -3.2f, 3.2f);

        // ���ׂẴT�u�J�����I�u�W�F�N�g���}�E�X�̈ʒu�Ɉړ�
        foreach (GameObject obj in subCameraObjects) {
            Vector3 newPosition = new Vector3(worldPosition.x, worldPosition.y, obj.transform.position.z);
            obj.transform.position = newPosition;
        }
    }
}
