using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainSpawner : MonoBehaviour
{
    public GameObject train;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    private Vector3 startPos;
    private Vector3 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        targetPos = new Vector3(251f, transform.position.y, transform.position.z);
        InvokeRepeating("spawnObject", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    public void spawnObject()
    {
        //Debug.Log(startPos);
        Instantiate(train, startPos, transform.rotation);
        if (stopSpawning) {
            CancelInvoke("spawnObject");
        }
    }
}
