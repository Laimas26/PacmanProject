using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public Rigidbody rb;
    public Animator anim;
    public float speed = 1.0f;

    void Start()
    {
        
    }

    private void FixedUpdate()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);

        if (movement == Vector3.zero)
        {
            return;
        }

        Quaternion targetRotation = Quaternion.LookRotation(movement);

        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

        //rb.MoveRotation(targetRotation);

        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Rotate(new Vector3(0, 90, 0));
        //    rb.AddForce(Vector3.left);
        //    //anim.SetFloat("speed", speed);
        //}
            
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Rotate(new Vector3(0, 270, 0));
        //    rb.AddForce(Vector3.right);
        //    //anim.SetFloat("speed", speed);
        //} 
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Rotate(new Vector3(0, 180, 0));
        //    rb.AddForce(Vector3.forward);
        //    //anim.SetFloat("speed", speed);
        //}
            
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Rotate(new Vector3(0, 0, 0));
        //    rb.AddForce(Vector3.back);
        //    //anim.SetFloat("speed", speed);
        //}


        //if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        //{
        //    anim.SetFloat("speed", 0);
        //}

        //speed = Input.GetAxis("Horizontal");

        //anim.SetFloat("speed", speed);

    }
}
