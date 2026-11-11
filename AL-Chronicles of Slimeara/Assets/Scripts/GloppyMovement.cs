using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GloppyMovement: MonoBehaviour
{
    private int rotation;
    public Rigidbody rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("idleRotation", 0f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.right * speed);
    }
    public void idleRotation()
    {
        rotation = Random.Range(-6, 6);
        transform.Rotate(0, -rotation, 0);
    }
}
