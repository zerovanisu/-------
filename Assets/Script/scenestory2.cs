using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class scenestory2 : MonoBehaviour
{
    //インスペクターで取得
    [SerializeField] UnityEngine.UI.Text textbox;
    [SerializeField] UnityEngine.UI.Text textbox2;
    [SerializeField] SpriteRenderer body, face;
    [SerializeField] SpriteRenderer body2, face2;
    [SerializeField] SpriteAtlas atlas;
    [SerializeField] SpriteAtlas atlas2;

    // イメージを白黒に設定
    [SerializeField] Color btnColor1 = Color.white;
    [SerializeField] Color btnColor2 = Color.black;
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
        textbox.text = "なんとかボスを追い払ったわね";
        textbox2.text = "ベル";
        body2.sprite = atlas2.GetSprite("ベル_デフォルト");
        face2.sprite = atlas2.GetSprite("ベル_笑顔");
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        textbox.text = "ああ、これで落ち着いて散策が…";
        textbox2.text = "アダム";
        body.sprite = atlas.GetSprite("頭身アダム_デフォルト");
        face.sprite = atlas.GetSprite("アダム_笑顔");
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        textbox.text = "狼の遠吠え";
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        textbox.text = "…できそうにないな";
        textbox2.text = "アダム";
        body.sprite = atlas.GetSprite("頭身アダム_デフォルト");
        face.sprite = atlas.GetSprite("アダム_怒り");
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        textbox.text = "もう！何匹相手にすればいいの！";
        textbox2.text = "ベル";
        body2.sprite = atlas2.GetSprite("頭身ベル_デフォルト");
        face2.sprite = atlas2.GetSprite("ベル_怒り");
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        textbox.text = "おーい！そこのお前さんたちー！";
        textbox2.text = "男の声";
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        textbox.text = "！！";
        textbox2.text = "アダム&ベル";
        body2.sprite = atlas2.GetSprite("頭身ベル_デフォルト");
        face2.sprite = atlas2.GetSprite("ベル_驚き");
        body.sprite = atlas.GetSprite("頭身アダム_デフォルト");
        face.sprite = atlas.GetSprite("アダム_驚き");
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        textbox.text = "こっちに抜け道があるんだ！奴らの群れが来る前に早く！";
        textbox2.text = "男の声";
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        textbox.text = "…迷ってる暇はなさそうね";
        textbox2.text = "ベル";
        body2.sprite = atlas2.GetSprite("頭身ベル_デフォルト");
        face2.sprite = atlas2.GetSprite("ベル_デフォルト");
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        textbox.text = "ああ、行くぞ！";
        textbox2.text = "アダム";
        body.sprite = atlas.GetSprite("頭身アダム_デフォルト");
        face.sprite = atlas.GetSprite("アダム_デフォルト");
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
    }

    private IEnumerator Button()
    {
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        OnClick2();
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        OnClick1();
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        OnClick1();
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        OnClick1();
        OnClick2();
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        OnClick1();
        yield return null;
        OnClick2();
        yield return null;
        OnClick1();
        OnClick2();
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        OnClick1();
        yield return null;
        OnClick1();
        yield return new WaitUntil(() => Input.GetKeyUp("s"));
        yield return null;
    }

    public void OnClick1()
    {
        btnChangeFlag = !btnChangeFlag;
        image.color = btnChangeFlag ? btnColor1 : btnColor2;
        face.color = btnChangeFlag ? btnColor1 : btnColor2;
    }

    public void OnClick2()
    {
        btnChangeFlag = !btnChangeFlag;
        image2.color = btnChangeFlag ? btnColor1 : btnColor2;
        face2.color = btnChangeFlag ? btnColor1 : btnColor2;
    }
}
