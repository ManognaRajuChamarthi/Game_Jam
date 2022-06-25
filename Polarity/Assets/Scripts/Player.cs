using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Variables
    public float jumpSpeed;
    public float polarity;
    private Rigidbody rb;

    public bool isGrounded; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded== true)
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            isGrounded = false;
            Debug.Log("is jumping");
        }
    }

    void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }

}
