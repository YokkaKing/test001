using UnityEngine;
using UnityEngine.SceneManagement;

public class SampleSceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            SceneManager.LoadScene("KYOU_NO_OHIRU_HA_YAKINIKU_DATTAYO");
        }
    }
}
