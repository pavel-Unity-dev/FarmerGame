using UnityEngine;
public class Pause : MonoBehaviour
{
   private bool isPauseGame = false;

    public GameObject pauseMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPauseGame)
            {
                Resume();
            }
            else
            {
                OnPause();
            }
        }
    }

    private void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        isPauseGame = false;
    }

    private void OnPause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPauseGame = true;
    }
    
}
