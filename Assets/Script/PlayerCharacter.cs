using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCharacter : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;

    // 向上的力
    public float upForce;
    // 状态
    public bool isAlive = true;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    public void Up()
    {
        if(!isAlive) return;
        // 触发向上动画的触发器
        _animator.SetTrigger("Up");
        //清空原速度
        _rigidbody2D.velocity = Vector2.zero;
        // 添加向上的力
        _rigidbody2D.AddForce(new Vector2(0 ,upForce));
        //GameMode.Instance.ScoreUp();
    }

    public void Die()
    {
        // 状态设置
        isAlive = false;
        // 播放死亡动画
        _animator.SetTrigger("Die");
        // 清空速度
        _rigidbody2D.velocity = Vector2.zero;
        // 游戏结束
        GameMode.Instance.GameOver();
    }

    private void OnCollisionEnter2D(Collision2D collsion)
    {
        Die();
    }
}
