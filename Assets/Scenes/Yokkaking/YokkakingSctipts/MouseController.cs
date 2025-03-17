using Unity.VisualScripting;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 左クリック
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // マウス座標をワールド座標に変換
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero); // クリック位置にレイを飛ばす

            if (hit.collider != null && hit.collider.CompareTag("object")) // タグが "object" なら
            {
                OnClick(hit.collider.gameObject); // クリックされたオブジェクトを渡す
            }
            else if (hit.collider == null)
            {
                OnClick(null);
            }
        }
    }

    void OnClick(GameObject clickedObject) // 左クリックされた時
    {
        if (clickedObject != null)
        {
            Debug.Log(clickedObject.name + " がクリックされた！（タグ: object）"); // クリックされたオブジェクトの名前をデバックする
        }
        else
        {
            Debug.Log("クリックが空を切った！！！");
        }
    }
}