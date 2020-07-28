using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Belle;

    void Start()
    {

    }

    void Update()
    {
        Vector3 BellePos = Belle.transform.position;

        //カメラとプレイヤーの位置を同じにする
        transform.position = new Vector3(BellePos.x, -1.7f, -4);
    }

}