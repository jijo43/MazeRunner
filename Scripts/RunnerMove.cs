using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerMove : MonoBehaviour
{
 
    public Rigidbody rb;

    public float forwardForce = 1500f;
    public float sidewaysForce = 500f;
    [SerializeField] private AudioSource BackgroundMusic;
    [SerializeField] private AudioSource Falltrack;
   
    


    // Update is called once per frame
    void FixedUpdate()
    { 
     
        rb.AddForce(0,0,forwardForce*Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow)|| Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.LeftArrow)|| Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
                    
            BackgroundMusic.Stop();
            Falltrack.Play();
            FindObjectOfType<GameManager>().LevelFailed();

        }
        if (Input.GetKey(KeyCode.Space))
        {
            FindObjectOfType<GameManager>().Pause();
            

        }
        if (Input.GetKey(KeyCode.Escape))
        {
            FindObjectOfType<GameManager>().Close();


        }





    }
    
}
