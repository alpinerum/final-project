using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcController : MonoBehaviour
{

    public Animator anim;
    Vector3 speed;
    //float timer;
    // Start is called before the first frame update
    void Start()
    {
        //timer = 0.0f;
        anim = GetComponent<Animator>();
    }

    void OnBecameInvisible() {
        //Debug.Log("hello");
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        speed.z = -3.0f * Time.deltaTime;

        transform.position = transform.position + new Vector3(0, 0, speed.z);
        // if (hit.transform.gameObject.name == "Centre" || hit.transform.gameObject.name == "Red Cylinder"
        //     || hit.transform.gameObject.name == "Blue Cylinder" || hit.transform.gameObject.name == "right cap" ||
        //     hit.transform.gameObject.name == "left cap") {
        //         anim.SetBool("collide", true);
        //     }
    }
    void OnCollisionEnter(Collision other) {
        Debug.Log(other);
        anim.SetBool("collide", true);
        speed.z = 0.0f * Time.deltaTime;
        transform.position = transform.position + new Vector3(0, 0, speed.z);
        StartCoroutine(coroutine());
    }
    
    IEnumerator coroutine() {
        Debug.Log("hello");
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }

    
}
