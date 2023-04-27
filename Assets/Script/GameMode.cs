using System;
using System.Collections;
using System.Collections.Generic;
using Script;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMode : MonoBehaviour
{
    public static GameMode Instance;
    // 使用状态机来定义游戏的状态
    private GameStateEnum _gameState;
    // 场景移动速度暴露get,set 并 设置默认值
    public float scrollSpeed { get; set; } = -1.5f;
    
    // UI
    public Text scoreText;
    public GameObject gameOverUI;
    
    // 分数
    private int _score = 0;

    void Start()
    {
        _gameState = GameStateEnum.GameStart;
    }

    void Awake()
    {
        Instance = this;
    }


    void Update()
    {
        if (isGameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void ScoreUp()
    {
        if (isGameOver) return;
        _score++;
        scoreText.text = "Score: "+_score.ToString();   
    }
    
    //游戏开始
    public void GameStart()
    {
        _gameState=GameStateEnum.GameStart;
        gameOverUI.SetActive(false);
    }

    //游戏结束
    public void GameOver()
    {
        _gameState = GameStateEnum.GameOver;
        gameOverUI.SetActive(true);
    }
    //游戏进行中
    public void GamePlaying()
    {
        _gameState=GameStateEnum.GamePlaying;
    }
    //获取游戏状态
    public GameStateEnum getGameState()
    {
        return _gameState;
    }
    
    
    //是否在游戏中
    public bool isPlaying
    {
        get { return _gameState == GameStateEnum.GamePlaying; }
    }
    //是否游戏结束
    public bool isGameOver
    {
        get { return _gameState == GameStateEnum.GameOver; }
    }
    //是否游戏开始
    public bool isGameStart
    {
        get { return _gameState == GameStateEnum.GameStart; }
    }
}


