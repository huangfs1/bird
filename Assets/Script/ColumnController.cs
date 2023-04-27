using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//生成柱子的脚本
public class ColumnController : MonoBehaviour
{
    // 柱子列表
    private GameObject[] _columns;
    private int _currentColumn = 0;
    
    //柱子最大数量
    public int columnMax = 5;
        
    // 生成间隔
    public float spawnRate = 3f;
    
    //生成在Y轴的区间
    public float yMin = 1.5f;
    public float yMax = 6f;
    
    //默认情况下X轴生成位置
    public float xPos = 10f;
    
    // 距离上一次生成时间
    private float _timeSinceLastSpawned;
    
    // 柱子预制体
    public GameObject columnPrefab;
    
    // 生成位置
    Vector2 originalPos = new Vector2(-10,-20);

    
    
    // Start is called before the first frame update
    void Start()
    {
        _columns = new GameObject[columnMax];
        for (int i = 0; i < columnMax; i++)
        {
            _columns[i] = Instantiate(columnPrefab, originalPos,Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        _timeSinceLastSpawned += Time.deltaTime;
        if (GameMode.Instance.isGameStart && _timeSinceLastSpawned >= spawnRate)
        {
            _timeSinceLastSpawned = 0f;
            float yPos = Random.Range(yMin, yMax);
            _columns[_currentColumn].transform.position = new Vector2(xPos,yPos);
            _currentColumn++;

            if (_currentColumn >= columnMax)
            {
                _currentColumn = 0;
            }
        }
    }
}
