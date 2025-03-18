using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class Stage2_ActionScript : MonoBehaviour {
    public string newTag = "test2"; // �V�����^�O
    public Sprite sprite; // �V�����摜�i�X�v���C�g�j
    void Update()
    {
        if (VarScripts.ACTION) {
            gameObject.tag = newTag;
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = sprite;
        }
    }
}
