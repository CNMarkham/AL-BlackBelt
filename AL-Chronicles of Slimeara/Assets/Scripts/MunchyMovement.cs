using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunchyMovement : MonoBehaviour
{
    private Rigidbody rigidbody;
    private RaycastHit hit;
    public bool inRange;
    public LayerMask targetLayer;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
        InvokeRepeating("Boing", 10f, 5f);
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position + new Vector3(0, 0, 0), transform.right, 5, targetLayer)|| Physics.Raycast(transform.position + new Vector3(0, 0, 0), transform.up, 5, targetLayer))
        {
            inRange = true;
            anim.SetBool("InRange", true);
        }
        else 
        {
            inRange = false;
            rigidbody.AddForce(transform.right * 0.5f);
            anim.SetBool("InRange", false);
        }
        Debug.Log(inRange);
    }
    void Boing()
    {
        if (!inRange)
        {
            rigidbody.AddForce(transform.up * 400f);
        }
        else
        {

        }
    }
}
