using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRun : MonoBehaviour
{
    
     float speed = 0.25f;
     float rotspeed = 80;
     float gravity = 8;
     float rot = 0;
    Vector3 moveDir = Vector3.zero;

    //CharacterController kontrol;
    Animator anim; 
    
    void Start()
    {
        //kontrol = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

         
            if (Input.GetKey(KeyCode.W))
            {
                moveDir = new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, 1 * speed * Time.deltaTime) ;
                anim.SetInteger("run", 1);
                gameObject.transform.position = moveDir;
            }
            else
            {
                moveDir = new Vector3(0, 0, 0);
                anim.SetInteger("run", 0);
            }
        
        
    }
}
