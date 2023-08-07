using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public int life = 3;
    public Text scoreText;
    public Text bestComboText;
    public GameObject gameOverScreen;
    public GameObject player;
    public GameObject spawner;
    public GameObject canvaText;
    [SerializeField] private string menuName;
    public float timer = 0;
    public int bestCombo;
    public AudioSource music;

    
    public float moveSpeed = 20f;

    [ContextMenu("Mais pontos")]
    public void addScore(int score)
    {
        music.loop = false;
        music.Play();
        playerScore = playerScore + 1;
        scoreText.text = $"Combo: {playerScore} \nLife: {life}";
        
    }

    public void errorAndGameOver()
    {
        life--;
        if(playerScore > bestCombo)
        {
            bestCombo = playerScore;
        }
        playerScore = 0;
        scoreText.text = $"Combo: {playerScore} \nLife: {life}";
        if(life == 0)
        {
            canvaText.SetActive(false);
            gameOverScreen.SetActive(true);
            bestComboText.text = $"Best Combo: {bestCombo}";
            Destroy(player);
            Destroy(spawner);
            
        }
    }

    public void restartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Exit()
    {
        SceneManager.LoadScene(menuName);
    }


    private void Update() {
        timer += Time.deltaTime;
        if(timer > 10)
        {
            moveSpeed += 1f;
            timer = 0;
        }
    }
}
