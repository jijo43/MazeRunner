
using UnityEngine;

public class RunnerCollision : MonoBehaviour
{
    public RunnerMove movement;
    public Rigidbody rb;
    [SerializeField] private AudioSource ballHitSound;
    [SerializeField] private AudioSource backgroundMusic;
    

    public void OnCollisionEnter(Collision collision)
    {
       if (collision.collider.tag == "Barrier")
        {
            ballHitSound.Play();
            backgroundMusic.Stop();
            
            movement.enabled = false;
            rb.freezeRotation = true;
            
            
            
            FindObjectOfType<GameManager>().LevelFailed();
  
        }
       
               
        
    }

}
