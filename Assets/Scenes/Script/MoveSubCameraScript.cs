using UnityEngine;

public class MoveSubCameraScript : MonoBehaviour
{
    public string tagName = "SubCamera"; // �^�O�����w��
    private GameObject subCameraObject;

    void Start() {
        // �^�O���g���ăI�u�W�F�N�g���擾
        subCameraObject = GameObject.FindGameObjectWithTag(tagName);
    }

    void Update() {
        if (subCameraObject != null) {
            // �}�E�X�̃��[���h���W���擾
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = Camera.main.nearClipPlane; // �J�����̃N���b�v���ʂ��l��
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            // X����Y���͈̔͂𐧌�
            worldPosition.x = Mathf.Clamp(worldPosition.x, -6.1f, 6.1f);
            worldPosition.y = Mathf.Clamp(worldPosition.y, -3.2f, 3.2f);

            // �T�u�J�����I�u�W�F�N�g���}�E�X�̈ʒu�Ɉړ�
            Vector3 newPosition = new Vector3(worldPosition.x, worldPosition.y, subCameraObject.transform.position.z);
            subCameraObject.transform.position = newPosition;
        }
    }
}