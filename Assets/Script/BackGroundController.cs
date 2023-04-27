using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//控制背景移动的脚本

public class BackGroundController : MonoBehaviour
{
    private BoxCollider2D _groundCollider;
    private float _groundLength;
    
    // Start is called before the first frame update
    void Start()
    {
        _groundCollider = GetComponent<BoxCollider2D>();
        _groundLength = _groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -_groundLength)
        {
            Vector2 offset = new Vector2(_groundLength * 2f,0);
            transform.position = (Vector2) transform.position + offset;
        }
    }
}
