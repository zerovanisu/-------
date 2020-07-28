﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// シーン遷移のフェードイン/アウト
public class FadeInOut : MonoBehaviour
{
    
    //フェードアウト処理の開始、完了を管理するフラグ
    private bool isFadeOut = false;
    //フェードイン処理の開始、完了を管理するフラグ
    private bool isFadeIn = true;
    //透明度が変わるスピード
    float fadeSpeed = 0.75f;
    //画面をフェードさせるための画像をパブリックで取得
    public Image fadeImage;
    float red, green, blue, alfa;
    // シーン遷移のための型
    string afterScene;

    // Start is called before the first frame update
    void Start()
    {
        
        SetRGBA(0, 0, 0, 1);
        //シーン遷移が完了した際にフェードインを開始するように設定
        SceneManager.sceneLoaded += fadeInStart;

    }

    //シーン遷移が完了した際にフェードインを開始するように設定
    void fadeInStart(Scene scene, LoadSceneMode mode)
    {
        isFadeIn = true;
    }
   
    public void fadeOutStart(int red, int green, int blue, int alfa, string nextScene)
    {
        SetRGBA(red, green, blue, alfa);
        SetColor();
        isFadeOut = true;
        afterScene = nextScene;
    }
    // Update is called once per frame
    void Update()
    {
        if (isFadeIn == true)
        {
            //不透明度を徐々に下げる
            alfa -= fadeSpeed * Time.deltaTime;
            //変更した透明度を画像に反映させる関数を呼ぶ
            SetColor();
            if (alfa <= 0)
               isFadeIn = false;
        }
        if (isFadeOut == true)
        {
            //不透明度を徐々に上げる
            alfa += fadeSpeed * Time.deltaTime;
            //変更した透明度を画像に反映させる関数を呼ぶ
            SetColor();
            if (alfa >= 1)
            {
                isFadeOut = false;
                SceneManager.LoadScene(afterScene);
            }
        }
      
    }
    //画像に色を代入する関数
    void SetColor()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }
    //色の値を設定するための関数
    public void SetRGBA(int r, int g, int b, int a)
    {
        red = r;
        green = g;
        blue = b;
        alfa = a;
    }
}