using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitCharacter : MonoBehaviour
{
    public GameObject box;
    public Animator animator;
    // Start is called before the first frame update
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

        if(Input.GetKeyUp(KeyCode.E)){
            Vector3 newPosition = new Vector3(transform.position.x, transform.position.y + 3, transform.position.z);
            GameObject clone = Instantiate(box, newPosition, transform.rotation);
            clone.SetActive(true);
        }

        
    }
    void OnCollisionEnter(Collision collision)
    {
      
        animator.SetTrigger("getHit");
       
    }
}
