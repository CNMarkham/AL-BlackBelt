using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GloppyMovement: MonoBehaviour
{
    private int rotation;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("idleRotation", 6);
        rb.AddForce(transform.right * 1f);
    }
    public void idleRotation()
    {
        rotation = Random.Range(-2, 2);
        transform.Rotate(Vector3.down, rotation);
    }
}
