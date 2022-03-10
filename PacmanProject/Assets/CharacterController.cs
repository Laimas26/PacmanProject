using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public Animator anim;
    float speed = 1;

    void Start()
    {
        
    }

    private void Update()
    {

        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A))
            rb.AddForce(Vector3.left);
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right);
            anim.SetFloat("speed", speed);
        }
            
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(Vector3.forward);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(Vector3.back);

        //speed = Input.GetAxis("Horizontal");

        //anim.SetFloat("speed", speed);

    }
}
