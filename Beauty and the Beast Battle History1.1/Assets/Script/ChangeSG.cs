using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSG : MonoBehaviour
{
    [SerializeField]
    private GameObject changebutton1;
    [SerializeField]
    private GameObject changebutton2;
    [SerializeField]
    private GameObject changeC1;
    [SerializeField]
    private GameObject changeC2;

    private void Update()
    {
        if(Input.GetKey("r"))
        {
            changeSt1();
            
        }
        else
        {
            changeSt2();
        }
    }

    public void changeSt1()
    {
        changebutton1.SetActive(false);
        changebutton2.SetActive(true);
        changeC1.SetActive(true);
        changeC2.SetActive(false);
    }

    public void changeSt2()
    {
        changebutton1.SetActive(true);
        changebutton2.SetActive(false);
        changeC1.SetActive(false);
        changeC2.SetActive(true);
    }

    //IEnumerable change()
    //{
    //    changeSt1();
    //    yield return null;
    //    changeSt2();
    //}
}
