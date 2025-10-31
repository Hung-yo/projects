using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public List<DamageOnCollision> obstacleList;
    public Pawn pawn;
    public static bool gameOver = false;
    public static bool isPaused = false;
    public GameObject pauseMenuUI;
    public GameObject titleScreenUI;
    public GameObject scoreManagerUI;
    public static AudioSource backgroundMusic;
    public AudioListener gameOverAudioListener;
    public static float score;
    void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        obstacleList = new List<DamageOnCollision>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        backgroundMusic = GetComponent<AudioSource>();
        gameOverAudioListener.enabled = false;
        pauseMenuUI.SetActive(false);
        titleScreenUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (obstacleList.Count == 0 && !gameOver && pawn != null)
        {
            Debug.Log("Victory!");
            gameOver = true;
        }

        if (pawn == null && !gameOver)
        {
            Debug.Log("Failure");
            gameOverAudioListener.enabled = true;
            gameOver = true;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                UnpauseGame();

            }
            else
            {
                PauseGame();
            }
        }
    }

    public static void IncreaseScore()
    {
        score++;
        gameManager.scoreManagerUI.GetComponent<ScoreManager>().UpdateScore();
    }

    public void UnpauseGame()
    {
        pauseMenuUI.SetActive(false);
        isPaused = false;
    }
    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        isPaused = true;
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
