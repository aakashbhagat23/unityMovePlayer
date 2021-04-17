using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieScript : MonoBehaviour
{
    Animator animzombie;
    float speed = 1.0f;
 
    // Start is called before the first frame update
    void Start()
    {
        animzombie = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update(){
        //Walk Anim
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow)){
            // Debug.Log("forword");
            animzombie.SetTrigger("walk");
            animzombie.ResetTrigger("stop");
        }

        //stop Zombie
        if(Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.DownArrow)){
            animzombie.SetTrigger("stop");
            animzombie.ResetTrigger("walk");
        }
        //
    }
    void FixedUpdate()
    {
        
        //
        //move forward
        if(Input.GetKey(KeyCode.UpArrow)){
            // transform.position += Vector3.forward * Time.deltaTime * speed;
            transform.GetComponent<Rigidbody>().AddForce(new Vector3(0,0,1), ForceMode.VelocityChange);
            transform.GetComponent<Rigidbody>().rotation = Quaternion.LookRotation(Vector3.forward);

        }
        //

         //move back
        if(Input.GetKey(KeyCode.DownArrow)){
            // transform.position += Vector3.back * Time.deltaTime * speed;
            transform.GetComponent<Rigidbody>().AddForce(new Vector3(0,0,-1), ForceMode.VelocityChange);
            transform.GetComponent<Rigidbody>().rotation = Quaternion.LookRotation(Vector3.back);
        }
        //

         //move right
        if(Input.GetKey(KeyCode.RightArrow)){
            // transform.position += Vector3.right * Time.deltaTime * speed;
             transform.GetComponent<Rigidbody>().AddForce(new Vector3(1,0,0), ForceMode.VelocityChange);
             transform.GetComponent<Rigidbody>().rotation = Quaternion.LookRotation(Vector3.right);
        }
        //

         //move right
        if(Input.GetKey(KeyCode.LeftArrow)){
            // transform.position += Vector3.left * Time.deltaTime * speed;
             transform.GetComponent<Rigidbody>().AddForce(new Vector3(-1,0,0), ForceMode.VelocityChange);
             transform.GetComponent<Rigidbody>().rotation = Quaternion.LookRotation(Vector3.left);

        }
        //

    }
}
