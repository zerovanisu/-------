using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyT : MonoBehaviour
{
    public GameObject beast;//ターゲット(プレイヤー)
    private float rad;//ラジアン変数
    private Vector2 Position;//現在位置を代入する為の変数

    // Start is called before the first frame update
    void Start()
    {
        //atan2(目標方向のy座標 - 初期位置のy座標, 目標方向のx座標 - 初期位置のx座標)
        rad = Mathf.Atan2(
            beast.transform.position.ytransform.position.y,
            beast.transform.position.x - transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        // 現在位置をPositionに代入
        Position = transform.position;
        
        Position.x += speed.x * Mathf.Cos(rad);// x += SPEED * cos(ラジアン)
        Position.y += speed.y * Mathf.Sin(rad);// y += SPEED * sin(ラジアン)
        transform.position = Position;// 現在の位置に加算減算を行ったPositionを代入する
    }

}
