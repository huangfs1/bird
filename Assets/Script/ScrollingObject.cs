using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.velocity = new Vector2(GameMode.Instance.scrollSpeed,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameMode.Instance.isGameOver)
        {
            _rigidbody2D.velocity = Vector2.zero;
        }
    }
}
