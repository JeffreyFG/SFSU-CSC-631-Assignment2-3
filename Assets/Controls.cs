using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public GameObject box;
    public Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isRunning", true);
        }
        else{
            animator.SetBool("isRunning", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("walkBackwards", true);
        }
        else{
            animator.SetBool("walkBackwards", false);
        }

        if(Input.GetKeyUp(KeyCode.E)){
            Vector3 newPosition = new Vector3(transform.position.x, transform.position.y + 3, transform.position.z);
            GameObject clone = Instantiate(box, newPosition, transform.rotation);
            clone.name = "Box";
            clone.SetActive(true);
        }
    }
}
