using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using FMODUnity;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    [SerializeField] private float rotation;
     
    private Vector2 input;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    private void OnEnable()
    {
       InputManager.OnPlayerMovement += Move;
    }

    private void OnDisable()
    {
        InputManager.OnPlayerMovement -= Move;
    }


    private void Move(Vector2 input)
    {
        this.input = input;
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0, (input.x * rotation * Time.deltaTime), 0));
    }

    private void FixedUpdate()
    {
        Vector3 velocity = transform.forward * input.y;
        rb.MovePosition(rb.position +(velocity * speed * Time.deltaTime));
      
    }

    

   

}
