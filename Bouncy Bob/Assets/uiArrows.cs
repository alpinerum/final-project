using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiArrows : MonoBehaviour
{
    public GameObject leftGreenBox, rightGreenBox;
    // Start is called before the first frame update
    void Start()
    {
        leftGreenBox.SetActive(false);
        rightGreenBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left")) {
            leftGreenBox.SetActive(true);
            rightGreenBox.SetActive(false);
        }
        else if (Input.GetKeyDown("right")) {
            leftGreenBox.SetActive(false);
            rightGreenBox.SetActive(true);
        }
        if (!Input.anyKey) {
            leftGreenBox.SetActive(false);
            rightGreenBox.SetActive(false);
        }
    }
}
