using UnityEngine;

public class CameraButtonScript : MonoBehaviour
{
    private SubCameraScript subCameraScript; // ����Script�ւ̎Q��

    void Start() {
        // SubCameraScript�R���|�[�l���g�����I�u�W�F�N�g���������Ď擾
        subCameraScript = FindObjectOfType<SubCameraScript>();
    }

    public void ConecctSetSubCameraObjectsActive() 
    {
        subCameraScript.SetSubCameraObjectsActive();
    }
}
