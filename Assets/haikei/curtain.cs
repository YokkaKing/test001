using UnityEngine;
using UnityEngine.UI;

public class ImageSwitcher : MonoBehaviour
{
    public Image imageComponent;
    public Sprite newImage;
    private Vector2 clickPosition;

    void Start()
    {
        imageComponent = GetComponent<Image>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickPosition = Input.mousePosition;
            SwitchImageAtPosition(clickPosition);
        }
    }

    void SwitchImageAtPosition(Vector2 position)
    {
        // �����ŃN���b�N�ʒu�Ɋ�Â��ĉ摜��ύX���鏈����ǉ����܂�
        // �Ⴆ�΁A�N���b�N�ʒu�ɉ����ĈقȂ�摜��\������Ȃ�
        imageComponent.sprite = newImage;
    }
}