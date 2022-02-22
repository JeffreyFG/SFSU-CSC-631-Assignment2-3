using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Rigidbody cylinder;

   
    public Vector3 overTheShoulderOffset = new Vector3(0,1,-5);
    public Quaternion overTheShoulderRotation = Quaternion.Euler(0,0,0);
    public Vector3 topDownOffPosition = new Vector3(0,11,-3);
    public Quaternion topDownRotation =  Quaternion.Euler(80,0,0);
    
    public bool overTheShoulder = false;
    void Start()
    {
        Rigidbody[] firstList = GameObject.FindObjectsOfType<Rigidbody>();
        for(var i = 0; i < firstList.Length; i++)
        {
            Debug.Log(firstList[i].gameObject.name);
            if(firstList[i].name == "Cylinder")
            {
                cylinder = firstList[i];
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if(overTheShoulder)overTheShoulder= false;
            else overTheShoulder = true;
        }
        if(overTheShoulder)
        {
            transform.position = cylinder.position+overTheShoulderOffset;
            transform.rotation = overTheShoulderRotation;
        }
        else if(!overTheShoulder)
        {
            transform.position = topDownOffPosition;
            transform.rotation = topDownRotation;
        }
        
    }
}
