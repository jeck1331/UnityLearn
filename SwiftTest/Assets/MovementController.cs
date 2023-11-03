using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private CharacterController characterController;
    private Rigidbody rb;

    public float Speed = 5f;
    public float jumpForce = 10;

    public LayerMask groundLayer;
    public float raycastDistance = 0.6f;
    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.down, out hit, raycastDistance, groundLayer))
            isGrounded = true;
        else
            isGrounded = false;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Debug.Log("Hui hui");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        characterController.Move(move * Time.deltaTime * Speed);
    }
}
