using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change3 : MonoBehaviour
{
    [Header("フェード")] public FadeImage fade;
    [SerializeField]
    Text1 text1;
    bool IsTextPush = false;

    private bool firstPush = false;
    private bool goNextScene = false;

    //スタートボタンを押されたら呼ばれる
    public void PressStart()
    {
        Debug.Log("Press Start!");
        if (!firstPush)
        {
            Debug.Log("Go Next Scene!");
            fade.StartFadeOut();
            firstPush = true;
        }
    }

    private void Update()
    {
        text1.TextUpdate(IsTextPush);
        IsTextPush = false;

        if (!goNextScene && fade.IsFadeOutComplete())
        {
            SceneManager.LoadScene("Battle");
            goNextScene = true;
        }
        
    }

    public void PushText()
    {
        this.IsTextPush = true;
    }
}