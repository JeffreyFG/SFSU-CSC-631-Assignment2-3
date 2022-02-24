using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitCharacter : MonoBehaviour
{
    public GameObject box;
    public GameObject wall;
    public ParticleSystem fire;
    public ParticleSystem chest;
    public Animator animator;
    public bool isTrigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionStay(Collision collision) {
       
    }
    void OnCollisionEnter(Collision collision)
    {
         if(collision.gameObject.Equals(wall)){
            chest.Play(true);   
        }
        Debug.Log(collision.gameObject);
        if(collision.gameObject.name == "Box"){
            if(!animator.GetCurrentAnimatorStateInfo(0).IsName("hit")){
                fire.Play(true);
                animator.SetTrigger("getHit");
            }
        }
          
    }
}
