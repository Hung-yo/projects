using UnityEngine;

public class DeathRecenter : Death
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public override void Die()
    {
        Debug.Log("Pawn Died, teleported to origin");
        transform.position = Vector3.zero;
        Health health = GetComponent<Health>();
        health.currentHealth = health.maxHealth;
    }
}
