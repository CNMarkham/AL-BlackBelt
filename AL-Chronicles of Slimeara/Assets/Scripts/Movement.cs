using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Transform player;
    public float speed;
    public Quaternion quaternion;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.w))
        {
            player.position += transform.forward * Time.deltaTime * speed;
        }
    }
}
