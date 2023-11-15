using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rigidbody;
    [SerializeField] public float forwardForce = 800f;
    [SerializeField] public float sideForce = 800f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Propel the player object in a certain direction.
        rigidbody.AddForce(0, 0, forwardForce * Time.deltaTime);

        Movement();
    }

    public void Movement()
    {
        if (Input.GetKey("d"))
        {
            rigidbody.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            rigidbody.AddForce((-1) * sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
