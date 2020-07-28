using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{

    //　アイテムメニューを開くボタン
    [SerializeField]
    private GameObject itemButton;
    //　ゲーム再開ボタン
    [SerializeField]
    private GameObject reStartButton;
    //　アイテムメニューパネル
    [SerializeField]
    private GameObject itemPanel;
    // タイトルへのボタン
    [SerializeField]
    private GameObject Quit;

    public void StopGame()
    {
        Time.timeScale = 0f;
        itemButton.SetActive(false);
        reStartButton.SetActive(true);
        itemPanel.SetActive(true);
        Quit.SetActive(true);
    }

    public void ReStartGame()
    {
        itemPanel.SetActive(false);
        reStartButton.SetActive(false);
        itemButton.SetActive(true);
        Quit.SetActive(false);
        Time.timeScale = 1f;
    }
    public void ReturnTitle()
    {
        SceneManager.LoadScene("Title");
    }
}