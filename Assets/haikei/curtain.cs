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
        // ここでクリック位置に基づいて画像を変更する処理を追加します
        // 例えば、クリック位置に応じて異なる画像を表示するなど
        imageComponent.sprite = newImage;
    }
}