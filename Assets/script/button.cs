using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    //0:終了処理　1:タイトル画面　2:ゲーム画面　3:リザルト画面
    [SerializeField] int scene;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickStartButton()
    {
        switch (scene)
            {
            case 0:
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif

                break;
            case 1:
                SceneManager.LoadScene("TITLE");

                break;

            case 2:

                SceneManager.LoadScene("GAME");
                break;

            case 3:

                SceneManager.LoadScene("RESULT");
                break;
        }
        
    }
}
