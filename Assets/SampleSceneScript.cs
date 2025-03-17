using UnityEngine;
using UnityEngine.SceneManagement;

public class SampleSceneScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            SceneManager.LoadScene("KYOU_NO_OHIRU_HA_YAKINIKU_DATTAYO");
        }
    }
}
