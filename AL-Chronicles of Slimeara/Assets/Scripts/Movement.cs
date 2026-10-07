using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public RaycastHit hit;
    private float raycastDistance = 1f;
    private Transform player;
    public float speed;
    public float jumpHieght;
    private Rigidbody rb;
    public bool isGrounded;
    public Quaternion quaternion;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform;
        isGrounded = false;
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.Raycast(transform.position + new Vector3(0,0.5f,0), Vector3.down, raycastDistance, 1 << 6);
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * speed);
        }
        if (Input.GetKey(KeyCode.D) && isGrounded) 
        {
            transform.Rotate(Vector3.up);
        }
        if (Input.GetKey(KeyCode.A) && isGrounded)
        {
            transform.Rotate(Vector3.down);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) 
        {
            rb.AddForce(Vector3.up * jumpHieght);
        }
    }
}
