using UnityEngine;

public class Controller : MonoBehaviour
{
    public Pawn pawn;
    public GameManager gameManager;
    public KeyCode shootKey = KeyCode.Space;
    private Shooter shooter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameManager.gameManager;
        pawn = gameManager.pawn;
        shooter = GetComponent<Shooter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.pawn == null)
        {
            return;
        }
        else
        {
            if (Input.GetKey(KeyCode.W)) // Move forwards
            {
                pawn.MoveForward(pawn.moveSpeed);
            }

            if (Input.GetKey(KeyCode.A)) // Rotate counterclockwise
            {
                pawn.Rotate(pawn.rotationSpeed);
            }

            if (Input.GetKey(KeyCode.S)) // Move backwards
            {
                pawn.MoveForward(-1 * pawn.moveSpeed);
            }

            if (Input.GetKey(KeyCode.D)) // Rotate clockwise
            {
                pawn.Rotate(-1 * pawn.rotationSpeed);
            }

            if (Input.GetKeyDown(KeyCode.UpArrow)) // Translate north
            {
                pawn.TranslateVertically(pawn.worldSpaceSpeed);
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow)) // Translate west
            {
                pawn.TranslateHorizontally(-1 * pawn.worldSpaceSpeed);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow)) // Translate south
            {
                pawn.TranslateVertically(-1 * pawn.worldSpaceSpeed);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow)) // Translate east
            {
                pawn.TranslateHorizontally(pawn.worldSpaceSpeed);
            }

            if (Input.GetKeyDown(shootKey))
            {
                shooter.Shoot();
            }
        }
    }
}
