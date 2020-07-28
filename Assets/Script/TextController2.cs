using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextController2 : MonoBehaviour
{
    public string[] scenarios;
    [SerializeField] Text Text1;
    [SerializeField]
    [Range(0.001f, 0.3f)]
    float intervalForCharacterDisplay = 0.5f;  // 1文字の表示にかかる時間

    private string currentText = string.Empty;  // 現在の文字列
    private float timeUntilDisplay = 0;     // 表示にかかる時間
    private float timeElapsed = 1;          // 文字列の表示を開始した時間
    private int lastUpdateCharacter = -1;		// 表示中の文字数
    private int currentLine = 0;            // 現在の行番号

    // 文字の表示が終了しているかどうか
    public bool IsComplateDisplayText
    {
        get { return Time.time > timeElapsed + timeUntilDisplay; }
    }

    // Start is called before the first frame update
    void Start()
    {
        SetNextLine();
    }



    // Update is called once per frame
    void Update()
    {
        // 文字の表示が完了しているならクリック時に次の行を表示する
        if (IsComplateDisplayText)
        {
            if (currentLine < scenarios.Length && Input.GetMouseButtonDown(0))
            {
                SetNextLine();
            }
        }
        else
        {
            // 完了してないなら文字をすべて表示する
            if (Input.GetMouseButtonDown(0))
            {
                timeUntilDisplay = 0;
            }
        }

        // クリックから経過した時間が想定表示時間の何%かを確認し、表示文字数を出す
        int displayCharacterCount = (int)(Mathf.Clamp01
        ((Time.time - timeElapsed) / timeUntilDisplay) * currentText.Length);

        // 表示文字数が前回の表示文字数と異なるならテキストを更新する
        if (displayCharacterCount != lastUpdateCharacter)
        {
            Text1.text = currentText.Substring(0, displayCharacterCount);
            lastUpdateCharacter = displayCharacterCount;
        }
    }

    void SetNextLine()
    {
        currentText = scenarios[currentLine];
        // 想定表示時間と現在の時刻を保管
        timeUntilDisplay = currentText.Length * intervalForCharacterDisplay;
        timeElapsed = Time.time;
        currentLine++;
        // 文字カウントを初期化
        lastUpdateCharacter = -1;
    }

}

