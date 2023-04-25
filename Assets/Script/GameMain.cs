using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMain : MonoBehaviour
{
    // 开始按钮
    private Button _starButton;
    
    // Start is called before the first frame update

    private void Awake()
    {
        _starButton = GameObject.Find("BtnBegain").GetComponent<Button>();
        _starButton.onClick.AddListener(openGamePlay);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void openGamePlay()
    {
        SceneManager.LoadScene("GameScene");
    }
}
