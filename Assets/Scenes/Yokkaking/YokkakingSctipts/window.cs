using UnityEngine;

public class window : MonoBehaviour
{
    void Start()
    {
        Screen.SetResolution(1920, 1080, FullScreenMode.Windowed); // ウィンドウモードで解像度固定
    }
}
