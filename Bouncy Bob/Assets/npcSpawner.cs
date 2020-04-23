using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcSpawner : MonoBehaviour
{
    public GameObject npc, npc2, npc3, npc4, npc5, npc6, npc7, npc8, npc9;
    public GameObject person;
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
        // npcs = new GameObject[9];
        // for (int i = 0; i < npcs.length; i++) {
        //     npcs[i] = 
        // }
        spawnDelay = Random.Range(2.0f, 5.0f);
        Debug.Log("hello");
    }

    // Update is called once per frame
    void Update() {
        
        timer += Time.deltaTime;
        int npcPicker = Random.Range(0, 9);
        if (npcPicker == 0) {
            person = npc;
        }
        else if (npcPicker == 1) {
            person = npc2;
        }
        else if (npcPicker == 2) {
            person = npc3;
        }
        else if (npcPicker == 3) {
            person = npc4;
        }
        else if (npcPicker == 4) {
            person = npc5;
        }
        else if (npcPicker == 5) {
            person = npc6;
        }
        else if (npcPicker == 6) {
            person = npc7;
        }
        else if (npcPicker == 7) {
            person = npc8;
        }
        else {
            person = npc9;
        }
        if (timer > spawnDelay) {
            spawnDelay = Random.Range(2.0f, 5.0f);
            spawnSide = Random.Range(0, 2);
            playerPos = GameObject.Find("Centre").transform.position;
            if (spawnSide == 0) {
                startPos = new Vector3(138f, 1.2f, playerPos.z + spawnDistance);
                Instantiate(person, startPos, target);
            }
            else {
                startPos = new Vector3(165.7232f, 1.2f, playerPos.z + spawnDistance);
                Instantiate(person, startPos, target);
            }
            timer = 0.0f;
        }
        //Debug.Log(timer);
        
    }
}
