using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int lives = 3;


    public TMP_Text scoreText;
    public Slider slider;

    public GameObject gameOverMenu;
    public PlayerController playerController; 
    public Animator animator;

    public void AddLives(int value)
    {
        lives += value;
        slider.value = lives;
        if (lives <= 0)
        {
            GameOver();
            lives = 0;
        }
    }

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "Score: " + score.ToString();
    }

    public void GameOver()
    {
        animator.SetBool("IsGameOver", true);
        playerController.enabled = false;
        StartCoroutine(AnimDead());
    }

    IEnumerator AnimDead()
    {
        yield return new WaitForSeconds(3f);
        Time.timeScale = 0;
        gameOverMenu.SetActive(true);
    }
}
