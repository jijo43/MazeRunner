
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
  
 
    public GameObject completeLevelUI;
    public GameObject LevelFailedUI;
    [SerializeField] public GameObject PauseMenuPanel;
    [SerializeField] public AudioSource Bgm;
    [SerializeField] public GameObject RightCorner;
    [SerializeField] public GameObject LevelComplete;

    public void Start()
    {
        RightCorner = GameObject.Find("RightCorner");

    }
    public void completeLevel()
    {

        FindObjectOfType<RunnerMove>().enabled = false;


        completeLevelUI.SetActive(true);

        Invoke("LoadNextLevel", 2f);

    }
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }



    public void LevelFailed()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;

            LevelFailedUI.SetActive(true);
            //Invoke("Restart", restartDelay);
        }

    }
    public void Restart()
    {
      
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
    public void Resume()
    {
        
        PauseMenuPanel.SetActive(false);
        Time.timeScale = 1f;
        //RightCorner.SetActive(true);


        Bgm.Play();
    
        
    }
    public void Pause()
    {
       
        if (!gameHasEnded)
        {
            //RightCorner.SetActive(false);
           
            PauseMenuPanel.SetActive(true);
            Time.timeScale = 0f;
            Bgm.Pause();


        }
        

    }
    public void Close()
    {
        
        Application.Quit();
    }
    
}
