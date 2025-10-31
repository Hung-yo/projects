using UnityEngine;

public class ShooterBullet : Shooter
{
    public AudioSource shootSound;
    public GameObject bulletPrefab;
    public Pawn pawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Shoot()
    {
        Instantiate(bulletPrefab, pawn.transform.position, pawn.transform.rotation);
        if (shootSound != null)
        {
            shootSound.PlayOneShot(shootSound.clip, 1.0f);
        }
    }
}
