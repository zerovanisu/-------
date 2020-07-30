using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test2 : MonoBehaviour
{
    [SerializeField]
    float speed = 30.0f;
    Vector2 inputAxis;
    private Rigidbody2D _rig;
    public Rigidbody2D Rig { get { return this._rig ? this._rig : this._rig = GetComponent<Rigidbody2D>(); } }



    void Start()
    {

    }

    void Update()
    {
        inputAxis.x = Input.GetAxis("Horizontal");
        inputAxis.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Rig.MovePosition(Rig.position + inputAxis * speed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        SceneManager.LoadScene("Boss area");
    }
}