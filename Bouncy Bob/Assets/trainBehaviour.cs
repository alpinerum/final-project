using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainBehaviour : MonoBehaviour
{
    public GameObject train;
    private float speed = 60f;
    private Vector3 target;
    Quaternion rot;
    private GameObject[] wagons;
    
    trainSpawner trainspawner;
    float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject spawner = GameObject.Find("train spawner");
        trainspawner = spawner.GetComponent<trainSpawner>();

        //wagons = new GameObject[3];
        target = new Vector3(330f, transform.position.y, transform.position.z);
        rot = Quaternion.Euler(0, -90, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // wagons[0] = GameObject.Find("HighSpeed_Front");
        // wagons[1] = GameObject.Find("HighSpeed_Wagon");
        // wagons[2] = GameObject.Find("HighSpeed_Wagon (1)");
        // Debug.Log(wagons[1]);
        // // for (int i = 0; i < 3; i++) {
        // //     wagons[i].transform.parent = train.transform;
        // // }
        // // wagons[0].transform.localPosition = new Vector3(0, 0, -33.7f);
        // // wagons[1].transform.localPosition = new Vector3(0,0,0);
        // // wagons[2].transform.localPosition = new Vector3(0,0,33.7f);
        // // wagons = new GameObject();
        // // wagons.transform.parent = train.transform;
        // // wagons.transform.localPosition = new Vector3(0, 0, 0);
        float step = speed * Time.deltaTime;
        timer += Time.deltaTime;
        // wagons[0].transform.position = Vector3.MoveTowards(transform.position, target, step);
        // wagons[1].transform.position = Vector3.MoveTowards(transform.position, target, step);
        // wagons[2].transform.position = Vector3.MoveTowards(transform.position, target, step);
        transform.position = Vector3.MoveTowards(transform.position, target, step);
        transform.rotation = rot;
        Debug.Log(timer);
        if (transform.position.x >= 280) {
            Destroy(GameObject.Find("Train(Clone)"));
            if (timer > trainspawner.spawnDelay) {
                transform.position = new Vector3(14.4f, 1.3f, 441.5f);
                timer = 0.0f;
            }
        } 
    }
}
