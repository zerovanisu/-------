using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade_Object4 : MonoBehaviour
{
    GameObject ManageObject4;
    FadeInOut fadeManager;
    // Start is called before the first frame update
    void Start()
    {
        //SceneFadeManagerがアタッチされているオブジェクトを取得
        ManageObject4 = GameObject.Find("ManageObject4");
        //オブジェクトの中のSceneFadeManagerを取得
        fadeManager = ManageObject4.GetComponent<FadeInOut>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Scenecahnge()
    {
        //SceneFadeManagerの中のフェードアウト開始関数を呼び出し
        fadeManager.fadeOutStart(0, 0, 0, 0, "Scene2");
    }
}
