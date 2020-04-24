using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject winUI;
    public static bool GameIsPaused = false;
    public GameObject scoreText;
    public static float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        winUI.SetActive(false);
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score = (GameObject.Find("Centre").transform.position.z - (-45f))*10f;
        if(GameObject.Find("Player").transform.position.z >= 1030f) {
            scoreText.GetComponent<Text>().text = score.ToString("F0");
            winUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
    }

    public void QuitGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
