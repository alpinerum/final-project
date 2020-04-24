using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float bounce = 15f;
    public float gravity = -9.8f;
    //private float timer = 0.0f;

    public static bool dead;
    public Transform groundCheck;
    public float groundDistance = 0.1f;
    public LayerMask groundMask;

    public GameObject Cap;

    gameOver gameover;
    private GameObject game_over;

    bool isLeftGrounded, isRightGrounded, isCentreGrounded;
    bool canDieOnGround;
    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        dead = false;
        game_over = GameObject.Find("Game Over");
        gameover = game_over.GetComponent<gameOver>();
    }

    // Update is called once per frame
    void Update()
    {
        //isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        //Debug.Log (isGrounded);
        //Debug.Log(velocity.y);
        isLeftGrounded = GameObject.Find("left cap").transform.position.y < 2.4;
        isRightGrounded = GameObject.Find("right cap").transform.position.y < 2.4;
        isCentreGrounded = GameObject.Find("Centre").transform.position.y < 2.3;
        var redCylinder = GameObject.Find("Red Cylinder").GetComponent<Rigidbody>().velocity;
        var angle = Mathf.Atan2(redCylinder.y, redCylinder.z) * Mathf.Rad2Deg;

        // timer += Time.deltaTime;
        // Debug.Log(timer);

        //float xAngle = GameObject.Find("Red Cylinder").transform.rotation.eulerAngles.x;
        float yAngle = GameObject.Find("Red Cylinder").transform.rotation.eulerAngles.y;
        float zAngle = GameObject.Find("Red Cylinder").transform.rotation.eulerAngles.z;
        //Debug.Log(yAngle);
        //Debug.Log(xAngle);
        //Debug.Log(yAngle);
        //Debug.Log(zAngle);
        //Debug.Log(GameObject.Find("left cap").transform.position);
        //Debug.Log(GameObject.Find("Centre").transform.position.y);
        if (isLeftGrounded && velocity.y < 0) {
            velocity.y = -2f;
            //Debug.Log("hello");
        }
        if (isRightGrounded && velocity.y < 0) {
            velocity.y = -2f;
        }
        if (isCentreGrounded && PauseMenu.canDieOnGround) {
            dead = true;
            //GameObject screen = game_over.transform.GetChild(0).gameObject;
            //screen.SetActive(true);
            //Debug.Log("Game Over");
        }
        if (Input.GetKey("left") && isLeftGrounded && !dead) {
            velocity.y = Mathf.Sqrt(bounce * -2f * gravity);
            velocity.z = Mathf.Abs(bounce * Mathf.Cos(yAngle*Mathf.Deg2Rad));
            velocity.x = Mathf.Abs(bounce * Mathf.Cos(zAngle*Mathf.Deg2Rad));
            //Debug.Log(Mathf.Tan(Mathf.Abs(90 - yAngle)));
            //Debug.Log(velocity.z);
            //Debug.Log("left");
        }
        else if (Input.GetKey("right") && isRightGrounded && !dead) {
            velocity.y = Mathf.Sqrt(bounce * -2f * gravity);
            velocity.z = bounce * Mathf.Cos(yAngle*Mathf.Deg2Rad);
            velocity.x = bounce * Mathf.Cos(zAngle*Mathf.Deg2Rad);
        }
        //Debug.Log(velocity.z);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    // void GameOver() {
    //     float timer = 0.0f;
    //     timer
    // }
}
