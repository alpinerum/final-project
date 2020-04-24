using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public GameObject gameOverUI;
    public static bool GameIsPaused = false;
    public GameObject scoreText;

    public static float score = 0;
    float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        gameOverUI.SetActive(false);
        score = 0;
    }

    void Update() {
        if (playerMovement.dead) {
            timer += Time.deltaTime;
            Pause();
        }
    }
    void Pause() {
        
        score = (GameObject.Find("Centre").transform.position.z - (-45f))*10f;
        Debug.Log(score);
        if (timer > 2f) {
            scoreText.GetComponent<Text>().text = score.ToString("F0");
            gameOverUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
    }

    public void QuitGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
