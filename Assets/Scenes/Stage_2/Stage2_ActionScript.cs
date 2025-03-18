using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class Stage2_ActionScript : MonoBehaviour {
    public string newTag = "test2"; // 新しいタグ
    public Sprite sprite; // 新しい画像（スプライト）
    void Update()
    {
        if (VarScripts.ACTION) {
            gameObject.tag = newTag;
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = sprite;
        }
    }
}
