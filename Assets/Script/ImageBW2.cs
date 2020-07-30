using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 話しているキャラを明るくしてそれ以外を黒くするスクリプト
public class ImageBW2 : MonoBehaviour
{
    //ここでカラーを設定
    [SerializeField]
    Color btnColor1 = Color.red;
    [SerializeField]
    Color btnColor2 = Color.blue;

    // オブジェクトからイメージを読み取り
    [SerializeField]
    Image image;
    [SerializeField]
    Image image2;
    public Image image3;

    //ボタンをキャッシュする変数
    bool btnChangeFlag = true;
    Button btn;
    void Awake()
    {
        //何度もアクセスするのでこの変数にキャッシュ
        btn = gameObject.GetComponent<Button>();
        
    }

    void Update()
    {
        int a = 0;
        if (Input.GetMouseButtonDown(0))　// コルーチンでマウスのボタンにより白、黒と色を変える
        {
            for (int i = 0; i < a; i++)
            {
                StartCoroutine(WaitButtonClick());
                ++a;
            }
        }
        else
        {
            image3.color = new Color(1, 1, 1, 1);
        }
    }
    // 画像を白黒変える
    public void OnClick1() // アダムを白黒にする
    {
        btnChangeFlag = !btnChangeFlag;
        image.color = btnChangeFlag ? btnColor1 : btnColor2;
    }

    public void OnClick2() // ベルを白黒にする
    {
        btnChangeFlag = !btnChangeFlag;
        image2.color = btnChangeFlag ? btnColor1 : btnColor2;
    }

    public IEnumerator WaitButtonClick()
    {
        while (true)
        {
            OnClick1();
            yield return null;
            OnClick2();
        }
    }
}
