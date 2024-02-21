using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public GameObject smoke;

    private Vector3 pos;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            Instantiate(smoke, playerMovement.transform.position, Quaternion.identity);
            playerMovement.animator.SetInteger("deathAnim", Random.Range(1, 2));
            playerMovement.enabled = false;

            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
