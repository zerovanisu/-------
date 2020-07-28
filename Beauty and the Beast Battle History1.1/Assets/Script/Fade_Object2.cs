using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade_Object2 : MonoBehaviour
{
     GameObject ManageObject2;
     FadeInOut fadeManager;
     // Start is called before the first frame update
     void Start()
     {
        //SceneFadeManagerがアタッチされているオブジェクトを取得
        ManageObject2 = GameObject.Find("ManageObject2");
        //オブジェクトの中のSceneFadeManagerを取得
        fadeManager = ManageObject2.GetComponent<FadeInOut>();
    }

     // Update is called once per frame
     void Update()
     {
     }

     public void Scenecahnge()
     {
         //SceneFadeManagerの中のフェードアウト開始関数を呼び出し
         fadeManager.fadeOutStart(0, 0, 0, 0, "Battle");
     }
}
