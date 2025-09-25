using UnityEngine;
using UnityEngine.InputSystem;

public class Teleport : MonoBehaviour
{
    public Key teleportKey;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[teleportKey].isPressed)
        {
            float randomX = Random.Range(-10f, 10f);
            transform.position = new Vector3(randomX, 0, 0);
        }
    }
}
