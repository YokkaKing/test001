using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public AudioClip ShutterSound; // 音を鳴らすやつ
    private AudioSource audioSource;


    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
    }


    void Update()
    {
        if (VarScripts.isDragging == false) // ドラッグしていなかったら
        {
            if (CompareTag("OBJECT")) // 自身のタグがOBJECTだったら
            {
                audioSource.clip = ShutterSound; // 音を鳴らす
                audioSource.Play(); // 音を鳴らす

                VarScripts.ACTION = true; // アクションをオン

                Destroy(gameObject); // このオブジェクトを消す
            }
            else if (CompareTag("object")) // 自身のタグがobjectだったら
            {
                VarScripts.ACTION = false; // アクションをオフ
            }
        }

        Debug.Log(VarScripts.ACTION);
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Action")) // Actionのタグに当たったら
        {
            if (CompareTag("object")) // このオブジェクトのタグがobjcetだったら
            {
                gameObject.tag = "OBJECT"; // タグをOBJECTに変更
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Action")) // Actionのタグから離れたら
        {
            if (CompareTag("OBJECT")) // このオブジェクトのタグがOBJECTだったら
            {
                gameObject.tag = "object"; // タグをobjectに戻す
            }
        }
    }
}