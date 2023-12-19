
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    [SerializeField] private AudioSource backgroundMusic;
    [SerializeField] private AudioSource Victory;


    public void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Player")
        {
            
            gameManager.completeLevel();
            
            Victory.Play();
            backgroundMusic.Stop();
        }
            
            
       
               
        

    }


}
