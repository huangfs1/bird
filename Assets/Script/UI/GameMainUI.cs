using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMainUI : MonoBehaviour
{
    // 开始按钮
    private Button _starButton;
    
    // Start is called before the first frame update

    private void Awake()
    {
            _starButton = GameObject.Find("StartBtn").GetComponent<Button>();
            _starButton.onClick.AddListener(openGamePlay);
    }
    
    private void openGamePlay()
    {
        SceneManager.LoadScene("GameScene");
    }
}
