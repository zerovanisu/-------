using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyT : MonoBehaviour
{

    GameObject beast;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove();
    }

    // ENEMYの移動関数1フレーム毎にUpdate関数から呼び出される
    void EnemyMove()
    {
        // PLAYERの位置を取得
        Vector2 targetPos = beast.transform.position;
        // PLAYERのx座標
        float x = targetPos.x;
        // ENEMYは、地面を移動させるので座標は常に0とする
        float y = 0;
        // 移動を計算させるための２次元のベクトルを作る
        Vector2 direction = new Vector2(
          x - transform.position.x, y).normalized;
        // ENEMYのRigidbody2Dに移動速度を指定する
        rb2d.velocity = direction * 2;
    }
}
