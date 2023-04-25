using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMode : MonoBehaviour
{

    public static GameMode Instance;
    // 游戏状态
    public bool gameOver = false;
    // 场景移动速度
    public float scrollSpeed = -1.5f;
        
    // UI
    public Text scoreText;
    public GameObject gameOverUI;
    
    // 分数
    private int _score = 0;
    void Awake()
    {
        Instance = this;
    }


    void Update()
    {
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void ScoreUp()
    {
        if (gameOver) return;
        _score++;
        scoreText.text = "Score: "+_score.ToString();
    }
    

    public void GameOver()
    {
        gameOver = true;
        gameOverUI.SetActive(true);
    } 
}
