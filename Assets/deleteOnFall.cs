using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteOnFall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(transform.position.y < 0.0){
        Destroy(this.gameObject);
     }   
    }
}
