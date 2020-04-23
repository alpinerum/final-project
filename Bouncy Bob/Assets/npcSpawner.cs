using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcSpawner : MonoBehaviour
{
    public GameObject npc;
    public float spawnDelay;
    //public float spawnTime;
    Vector3 playerPos;
    private float timer;
    private int spawnSide;

    private Vector3 startPos;
    
    float spawnDistance = 40;
    Quaternion target = Quaternion.Euler(0, 180f, 0);

    // Start is called before the first frame update
    void Start()
    {
        spawnDelay = Random.Range(2.0f, 5.0f);
        Debug.Log("hello");
    }

    // Update is called once per frame
    void Update() {
        
        timer += Time.deltaTime;
        if (timer > spawnDelay) {
            spawnDelay = Random.Range(2.0f, 5.0f);
            spawnSide = Random.Range(0, 2);
            playerPos = GameObject.Find("Centre").transform.position;
            if (spawnSide == 0) {
                startPos = new Vector3(138f, 1.2f, playerPos.z + spawnDistance);
                Instantiate(npc, startPos, target);
            }
            else {
                startPos = new Vector3(165.7232f, 1.2f, playerPos.z + spawnDistance);
                Instantiate(npc, startPos, target);
            }
            timer = 0.0f;
        }
        //Debug.Log(timer);
        
    }
}
