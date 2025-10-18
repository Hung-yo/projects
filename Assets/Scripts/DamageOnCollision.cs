using Unity.VisualScripting;
using UnityEngine;

public class DamageOnCollision : MonoBehaviour
{
    public int damageAmount = 1;
    public bool isObstacle = false;
    public bool hasCollided = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (isObstacle)
        {
            GameManager.gameManager.obstacleList.Add(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (hasCollided)
        {
            OnDestroy();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit " + other.gameObject.name);
        Health otherHealth = other.gameObject.GetComponent<Health>();
        if (otherHealth != null)
        {
            otherHealth.TakeDamage(damageAmount);
            hasCollided = true;
        }
        else
        {
            Debug.Log(other.gameObject.name + " has no health component.");
        }
    }
    
    void OnDestroy()
    {
        if (isObstacle)
        {
            GameManager.gameManager.obstacleList.Remove(this);
        }
        Destroy(gameObject);
    }
}
