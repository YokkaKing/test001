using UnityEngine;

public class MouseController2 : MonoBehaviour
{
    private bool isDragging = false; // ドラッグ中かどうか
    private Vector2 offset; // マウスとオブジェクトの距離の差分

    private Vector2 startPosition; // 初期位置を保存する変数
    Vector2 currentPosition; // 現在の位置を取得


    void Start()
    {
        startPosition = transform.position; // 初期位置を取得
    }


    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // マウスのワールド座標

        currentPosition = transform.position; // 常に現在の位置を取得

        if (Input.GetMouseButtonDown(0)) // 左クリックを押した瞬間
        {
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero); // マウスからrayを発射

            if (hit.collider != null && hit.collider.CompareTag("object")) // クリックしたオブジェクトが自分自身なら
            {
                isDragging = true; // ドラッグ中
                offset = (Vector2)transform.position - mousePosition; // クリック位置との差分を取得
            }
        }

        if (Input.GetMouseButton(0) && isDragging) // 左クリックを押し続けている間
        {
            transform.position = mousePosition + offset; // マウスの位置に追従
        }

        if (Input.GetMouseButtonUp(0)) // 左クリックを離したとき
        {
            isDragging = false; // ドラッグ中止

            if (CompareTag("object") && currentPosition != startPosition) // 自分のタグがobjectかつ初期位置じゃなければ
            {
                // ResetPosition(); // 初期位置に戻す
            }
        }
    }


    void ResetPosition() // 初期位置に戻る関数
    {
        transform.position = startPosition; // 初期位置に戻る
    }
}
