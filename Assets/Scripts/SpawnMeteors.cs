using UnityEngine;
using time = UnityEngine.Time;

public class SpawnMeteors : MonoBehaviour
{
    public GameObject meteorPrefab;
    public float screenDimensionX;
    public float screenDimensionY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        screenDimensionX = Camera.main.orthographicSize * Camera.main.aspect;
        screenDimensionY = Camera.main.orthographicSize;

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.isPaused == false && GameManager.gameOver == false)
        {
           
            StartCoroutine(SpawnMeteor());
        }
    }

    System.Collections.IEnumerator SpawnMeteor()
    {
        yield return new WaitForSeconds(40f);
        float spawnPosX;
        float spawnPosY;

        float spawnArea = Random.Range(1, 4);
        if (spawnArea == 1)
        {
            // Spawn in the top area
            spawnPosX = Random.Range(-screenDimensionX, screenDimensionX);
            spawnPosY = screenDimensionY + 1f;
        }
        else if (spawnArea == 2)
        {
            // Spawn in the bottom area
            spawnPosX = Random.Range(-screenDimensionX, screenDimensionX);
            spawnPosY = -screenDimensionY - 1f;
        }
        else if (spawnArea == 3)
        {
            // Spawn in the left area
            spawnPosX = -screenDimensionX - 1f;
            spawnPosY = Random.Range(-screenDimensionY, screenDimensionY);
        }
        else
        {
            // Spawn in the right area
            spawnPosX = screenDimensionX + 1f;
            spawnPosY = Random.Range(-screenDimensionY, screenDimensionY);
        }

        Vector3 spawnPosition = new Vector3(spawnPosX, spawnPosY, 0f);

        Instantiate(meteorPrefab, spawnPosition, Quaternion.identity);
    }
}
