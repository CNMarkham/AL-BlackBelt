using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{ 
    public List<GameObject> possibleSpawns = new List<GameObject>();
    public float currentTime;
    int randomIndex;
    // Start is called before the first frame update
    void Start()
    {
        randomIndex = Random.Range(0, possibleSpawns.Count);
        currentTime = 300;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= 300)
        {
            slimeSpawn();
            currentTime = 0;
        }
    }
    void slimeSpawn()
    {
        Instantiate(possibleSpawns[randomIndex], transform.position, transform.rotation);
    }
}
