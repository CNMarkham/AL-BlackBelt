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
        rotation = Random.Range(-12, 12);
        //InvokeRepeating("idleRotation", 0f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * -rotation * Time.deltaTime);
        //rb.AddForce(transform.right * speed);
    }
    public void idleRotation()
    {
    }
}
