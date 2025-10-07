using Unity.VisualScripting;
using UnityEngine;

public class DeathTests : MonoBehaviour
{
    public Pawn pawnToTest;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pawnToTest = GetComponent<Pawn>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            pawnToTest.death.Die();
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            //TODO: Take Damage
            pawnToTest.health.TakeDamage(1);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            //TODO: Heal
            pawnToTest.health.Heal(1);
        }
    }
}
