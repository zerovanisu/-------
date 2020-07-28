using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Change : MonoBehaviour
{
    [Header("フェード")] public FadeImage fade;

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
    public void End()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
    }

    private void Update()
    {
        if (!goNextScene && fade.IsFadeOutComplete())
        {
            SceneManager.LoadScene("chapter");
            goNextScene = true;
        }
    }
}