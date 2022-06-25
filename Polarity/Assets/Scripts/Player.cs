using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Variables
    public float jumpSpeed;
    private float polarity = 1;
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
            rb.AddForce(Vector3.up * jumpSpeed * polarity, ForceMode.Impulse);
            isGrounded = false;
            Debug.Log("is jumping");
        }
        
        Polarity();
    }

    void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }

    public void Polarity()
    {
        //get input for polarity change
        //invert gravity when input is recieved
        //make it so that charged polarity can make you attack enemy.(it takes about 5 seconds to charge)
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            polarity *= -1;
            Physics.gravity = new Vector3(0, 9.81f * (-polarity),0);
            Debug.Log("Polarity is reversed");
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            //becomes able to hit enemies.
            Debug.Log("I am right clicking");
        }

    }

}
