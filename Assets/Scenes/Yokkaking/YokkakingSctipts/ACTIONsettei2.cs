using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACTIONsettei2 : MonoBehaviour
{

    public bool action = false;

    // Start is called before the first frame update
    void Start()
    {
        VarScripts.ACTION2 = action;
    }

    private void Update()
    {
        Debug.Log(VarScripts.ACTION2);
    }
}
