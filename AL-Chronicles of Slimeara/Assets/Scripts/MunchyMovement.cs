using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunchyMovement : MonoBehaviour
{
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
        InvokeRepeating("Boing", 10f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(transform.right * 0.5f);
    }
    void Boing()
    {
        rigidbody.AddForce(transform.up * 400f);
    }
}
