using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerRb;
    public float forwardForce = 100f;
    public float sideForce = 100f;

    //private Vector2 moveAmount;

    private PlayerInput playerInput;
    private float direction = 0f;

    private void Awake()
    {
        playerInput = new PlayerInput();
        playerInput.Enable();

        playerInput.CubeMan.Movement.performed += ctx =>
        {
            direction = ctx.ReadValue<float>();
        };
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        playerRb.AddForce(0f, 0f, forwardForce * Time.deltaTime);

        playerRb.AddForce((direction * sideForce * Time.deltaTime), 0f, 0f, ForceMode.VelocityChange);

        if(playerRb.position.y < -1.5f)
        {

        }

        //Movimiento primitivo
        //if (Input.GetKey("d")) { playerRb.AddForce(sideForce * Time.deltaTime, 0f, 0f); }
        //if (Input.GetKey("a")) { playerRb.AddForce(-sideForce * Time.deltaTime, 0f, 0f); }
    }

    /*public void OnMove(InputAction.CallbackContext context)
    {
        moveAmount = context.ReadValue<Vector2>();
    }
    */
        private void OnEnable()
        {
            playerInput.Enable();
        }

        private void OnDisable()
        {
            playerInput.Disable();
        }
}
