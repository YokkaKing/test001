using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{

    public static bool ACTION = false;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Action")) // Actionのタグに当たったら
        {
            if (CompareTag("object")) // このオブジェクトのタグがobjcetだったら
            {
                gameObject.tag = "OBJECT"; // タグをOBJECTに変更
                ACTION = true;
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
                ACTION = false;
            }
        }
    }
}