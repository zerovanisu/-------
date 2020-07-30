using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class Scenestory : MonoBehaviour
{
    //インスペクターで取得
    [SerializeField] UnityEngine.UI.Text textbox;
    [SerializeField] UnityEngine.UI.Text textbox2;
    [SerializeField] SpriteRenderer body, face;
    [SerializeField] SpriteRenderer body2, face2;
    [SerializeField] SpriteAtlas atlas;
    [SerializeField] SpriteAtlas atlas2;
    SpriteRenderer spder;

    // イメージを白黒に設定
    [SerializeField]Color btnColor1 = Color.white;
    [SerializeField]Color btnColor2 = Color.black;
    [SerializeField] Image image;
    [SerializeField] Image image2;

    bool btnChangeFlag = true;

    private void Update()
    {
        if (Input.GetKeyUp("s"))
        {
            StartCoroutine(Button());
        }
    }

    //コルーチンからテキスト、話しているキャラを白黒させる、表情差分
    private IEnumerator Start()
    {
        textbox.text = "おい、大丈夫か？！";
        textbox2.text = "アダム";
        body.sprite = atlas.GetSprite("頭身アダム_透過 (1)");
        face.sprite = atlas.GetSprite("アダム_驚き");
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;

        textbox.text = "うぅ...頭フラフラする...って、ここどこなの？！";
        textbox2.text = "ベル";
        body2.sprite = atlas2.GetSprite("頭身ベル_透過");
        face2.sprite = atlas2.GetSprite("ベル_驚き");
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;

        textbox.text = "さぁな、俺の嗅ぎじゃ知らない森だぞ";
        textbox2.text = "アダム";
        body.sprite = atlas.GetSprite("頭身アダム_透過 (1)");
        face.sprite = atlas.GetSprite("アダム_デフォルト");
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;

        textbox.text = "確かこの本を開いたら、急に光ったりして...";
        textbox2.text = "ベル";
        body2.sprite = atlas2.GetSprite("頭身ベル_透過");
        face2.sprite = atlas2.GetSprite("ベル_デフォルト");
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;

        textbox.text = "ああ、気づいたらここだ。まさかあの世でも行ったのか！？";
        textbox2.text = "アダム";
        body.sprite = atlas.GetSprite("頭身アダム_透過 (1)");
        face.sprite = atlas.GetSprite("アダム_驚き");
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;

        textbox.text = "森の天国だなんて聞いたことないわ";
        textbox2.text = "ベル";
        body2.sprite = atlas2.GetSprite("頭身ベル_透過");
        face2.sprite = atlas2.GetSprite("ベル_デフォルト");
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;

        textbox.text = "本に転送魔法でも施されていたかしら？今は魔力が感じないね、しばらく使えないみたい";
        textbox2.text = "ベル";
        body2.sprite = atlas2.GetSprite("頭身ベル_透過");
        face2.sprite = atlas2.GetSprite("ベル_デフォルト");
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;

        textbox.text = "まずこの辺りに散策するか？ここで悩んでもしょうがないし";
        textbox2.text = "アダム";
        body.sprite = atlas.GetSprite("頭身アダム_透過 (1)");
        face.sprite = atlas.GetSprite("アダム_デフォルト");
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;

        textbox.text = "そうね、行くわ";
        textbox2.text = "ベル";
        body2.sprite = atlas2.GetSprite("頭身ベル_透過");
        face2.sprite = atlas2.GetSprite("ベル_デフォルト");
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
    }

    private IEnumerator Button()
    {
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        OnClick2();
        yield return null;
        OnClick1();
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        OnClick2();
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        OnClick1();
        OnClick2();
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        OnClick2();
        OnClick1();
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        OnClick1();
        OnClick2();
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        OnClick2();
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        OnClick2(); // 呼び出しを２回しているのでOnclick2が不安定に作動
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        OnClick1();
        OnClick2();
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        OnClick2();
        OnClick1();
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
    }


    // 画像を白黒変える
    public void OnClick1() // アダムを白黒にする(表情差分を追加したことによりα値は最大で設定)
    {
        //btnChangeFlag = !btnChangeFlag; （没）
        //for (int i = 0; i < 1; i++)
        //{
        //    if (btnChangeFlag)
        //    {
        //        image.color = btnColor1 = new Color(0, 0, 0, 1);
        //    }
        //    else if (!btnChangeFlag)
        //    {
        //        image.color = btnColor2 = new Color(1, 1, 1, 1);
        //    }
        //}
        btnChangeFlag = !btnChangeFlag;
        image.color = btnChangeFlag ? btnColor1 : btnColor2;
        face.color = btnChangeFlag ? btnColor1 : btnColor2;
    }

    public void OnClick2() // ベルを白黒にする
    {
        btnChangeFlag = !btnChangeFlag;
        image2.color = btnChangeFlag ? btnColor1 : btnColor2;
        face2.color = btnChangeFlag ? btnColor1 : btnColor2;
    } 
}
