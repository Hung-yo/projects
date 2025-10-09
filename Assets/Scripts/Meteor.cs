using JetBrains.Annotations;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public Pawn pawn;
    public float moveSpeed;
    public bool hasCollided = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        MoveTowards(pawn);
    }

    public void MoveTowards(Vector3 pointToMoveTowards)
    {
        // Find vector to that point
        Vector3 moveVector = pointToMoveTowards - transform.position;
        // Normalize it
        moveVector.Normalize();
        // Multiply by speed
        moveVector *= moveSpeed * Time.deltaTime;
        // Move that vector from current position
        transform.position = transform.position + moveVector;
    }

    public void MoveTowards(GameObject objectToMoveTowards)
    {
        MoveTowards(objectToMoveTowards.transform.position);
    }

    public void MoveTowards(Pawn pawnToMoveTowards)
    {
        MoveTowards(pawnToMoveTowards.transform.position);
    }

    public void MoveTowards(Transform transformToMoveTowards)
    {
        MoveTowards(transformToMoveTowards.position);
    }

}
