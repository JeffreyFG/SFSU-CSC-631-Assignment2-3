using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeLight : MonoBehaviour
{
    bool dark = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.L))
        {
            dark = !dark;
        }
        if(dark){
            GetComponent<Light>().color = Color.black;
        }
        else{
            GetComponent<Light>().color = Color.white;
        }
    }
}
