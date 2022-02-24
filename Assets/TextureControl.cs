using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureControl : MonoBehaviour
{
    private bool snowTextureBoolean;
    private bool fireTextureBoolean;

    public Texture fireTexture;
    public Texture snowTexture;

    private TerrainLayer[] layers;
    void Start()
    {
        snowTextureBoolean = true;
        fireTextureBoolean = false;    
        layers  = GetComponent<Terrain>().terrainData.terrainLayers;
    }

    // Update is called once per frame
    void Update()
    {
            
    }
    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(snowTextureBoolean)
            {
                snowTextureBoolean =false;
                fireTextureBoolean= true;
                layers[0].diffuseTexture= (Texture2D)snowTexture;
                
            }
            else if (fireTextureBoolean)
            {
                snowTextureBoolean = true;
                fireTextureBoolean = false;
                layers[0].diffuseTexture = (Texture2D)fireTexture;
            }
        }
    }
}
