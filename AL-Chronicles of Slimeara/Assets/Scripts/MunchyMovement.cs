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
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(transform.right * 1.5f);
    }
}
