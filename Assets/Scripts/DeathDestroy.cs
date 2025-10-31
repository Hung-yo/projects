using UnityEngine;

public class DeathDestroy : Death
{
    public AudioSource deathClip;
   
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
        DeathEvent();
        Destroy(gameObject);
    }

    public virtual void DeathEvent()
    {
        Debug.Log("Death event triggered");
        if (deathClip != null)
        {
            AudioSource.PlayClipAtPoint(deathClip.clip, transform.position);
        }
    }
}
