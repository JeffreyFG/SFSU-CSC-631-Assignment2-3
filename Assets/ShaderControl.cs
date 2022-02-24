using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderControl : MonoBehaviour
{
    // Start is called before the first frame update
    Shader shader1;
    Shader shader2;
    Renderer renderer;
    void Start()
    {
        renderer = GetComponent<Renderer> ();
        shader1 = Shader.Find("Diffuse");
        shader2 = Shader.Find("Transparent/Diffuse");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if (renderer.material.shader == shader1)
            {
                renderer.material.shader = shader2;
            }
            else
            {
                renderer.material.shader = shader1;
            }
        }
    }
}
