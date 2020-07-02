using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// オブジェクトに与えることでFadeIN/Outを使えるようにする
public class Fade_Object : MonoBehaviour
{
    GameObject ManageObject;
    FadeInOut fadeManager;
    // Start is called before the first frame update
    void Start()
    {
        //SceneFadeManagerがアタッチされているオブジェクトを取得
        ManageObject = GameObject.Find("ManageObject");
        //オブジェクトの中のSceneFadeManagerを取得
        fadeManager = ManageObject.GetComponent<FadeInOut>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void gamestart()
    {
        //SceneFadeManagerの中のフェードアウト開始関数を呼び出し
        fadeManager.fadeOutStart(0, 0, 0, 0, "Chapter");
    }

    public void EndGame() // ゲームを終了する
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
    }
}