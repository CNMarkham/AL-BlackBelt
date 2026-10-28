using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Targeting : MonoBehaviour
{
    public GameObject target;
    public Vector3 targetOffset;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(new Vector3 (target.transform.position.x, transform.position.y, target.transform.position.z));
        transform.Rotate(targetOffset, Space.Self);
    }
}
