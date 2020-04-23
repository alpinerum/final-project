using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcController : MonoBehaviour
{

    public Animator anim;
    Vector3 speed;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnBecameInvisible() {
        Debug.Log("hello");
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        speed.z = -3.0f * Time.deltaTime;;

        transform.position = transform.position + new Vector3(0, 0, speed.z);
    }

    
}
