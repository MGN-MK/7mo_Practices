using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public PlayerMovement playerMovement;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            playerMovement.enabled = false;

            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
