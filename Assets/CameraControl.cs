using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Rigidbody cylinder;
    public Vector3 overTheShoulderOffset;
    public Quaternion overTheShoulderRotation;
    public Vector3 topDownPosition;
    public Quaternion topDownRotation;
    
    public bool overTheShoulder;
    void Start()
    {
        overTheShoulderOffset = new Vector3(0,1,-5);
        overTheShoulderRotation = Quaternion.Euler(0,0,0);
        topDownPosition = new Vector3(0,11,-3);
        topDownRotation =  Quaternion.Euler(50,0,0);
        transform.rotation=  topDownRotation;
        overTheShoulder = false;
        Rigidbody[] firstList = GameObject.FindObjectsOfType<Rigidbody>();
        for(var i = 0; i < firstList.Length; i++)
        {
            Debug.Log(firstList[i].gameObject.name);
            if(firstList[i].name == "Standing Idle")
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
            transform.position = topDownPosition;
            transform.rotation = topDownRotation;
        }
    }
}
