using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public List<DamageOnCollision> obstacleList;
    public Pawn pawn;
    public bool gameOver = false;
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
            gameOver = true;
        }

    }
}
