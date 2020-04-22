using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject player;
    public float cameraHeight = 15f;
    public float cameraAdjust = 20f;
    public float cameraOffset = 50f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = player.transform.position;
        pos.y = cameraHeight;
        pos.z -= cameraOffset;
        pos.x += cameraAdjust;
        transform.position = pos;
    }
}
