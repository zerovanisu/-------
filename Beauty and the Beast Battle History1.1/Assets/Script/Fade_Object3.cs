using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade_Object3 : MonoBehaviour
{
    GameObject ManageObject3;
    FadeInOut fadeManager;
    // Start is called before the first frame update
    void Start()
    {
        //SceneFadeManagerがアタッチされているオブジェクトを取得
        ManageObject3 = GameObject.Find("ManageObject3");
        //オブジェクトの中のSceneFadeManagerを取得
        fadeManager = ManageObject3.GetComponent<FadeInOut>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Scenecahnge()
    {
        //SceneFadeManagerの中のフェードアウト開始関数を呼び出し
        fadeManager.fadeOutStart(0, 0, 0, 0, "Scene");
    }
}
