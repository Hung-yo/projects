using UnityEngine;
using UnityEngine.InputSystem;

public class PrintPosition : MonoBehaviour
{
    private float posX;
    private float posY;
    public Key printKey;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[printKey].wasPressedThisFrame)
        {
            posX = this.transform.position.x;
            Debug.Log("Position: " + posX);
        }
    }
}
