using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class Stage2_ActionScript : MonoBehaviour {
    public Sprite sprite; // �V�����摜�i�X�v���C�g�j
    public Sprite newsprite; // �V�����摜�i�X�v���C�g�j

    void Start() {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite;
    }

    void Update()
    {
        if (!VarScripts.ACTION) {
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = sprite;
        }

        if (VarScripts.ACTION) {
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = newsprite;
        }
    }
}
