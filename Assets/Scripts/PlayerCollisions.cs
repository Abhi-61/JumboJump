using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public PlayerMovement playermovement;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            Debug.Log("Hit an Obstacle");
            playermovement.enabled = false;
        }
        else
        {
            Debug.Log("You're on the floor");
        }
    }
}
