using UnityEngine;

public class Pawn : MonoBehaviour
{
    public float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveForward (float moveSpeed)
    {
        transform.Translate(Vector3.up * moveSpeed);
    }
}
