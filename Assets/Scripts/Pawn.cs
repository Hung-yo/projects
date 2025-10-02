using UnityEngine;

public class Pawn : MonoBehaviour
{
    public float baseSpeed;
    public float moveSpeed;
    public float rotationSpeed;
    public float worldSpaceSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            moveSpeed = baseSpeed * 2;
        }
        else
        {
            moveSpeed = baseSpeed;
        }
    }

    public void MoveForward(float moveSpeed)
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
    }

    public void Rotate(float rotationSpeed)
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }

    public void TranslateHorizontally(float worldSpaceSpeed)
    {
        transform.Translate(Vector3.right * worldSpaceSpeed, Space.World);
    }
    public void TranslateVertically(float worldSpaceSpeed)
    {
        transform.Translate(Vector3.up * worldSpaceSpeed, Space.World);
    }
}