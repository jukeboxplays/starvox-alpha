using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonVR : MonoBehaviour
{

    public bool b_01;
    public bool b_02;
    public bool b_03;
    Color32 colorOn;
    Color32 colorOff;

    void Start()
    {
        colorOn = new Color32(0,255,0,255);
        colorOff = new Color32(255,0,0,255);
    }

    void Update()
    {

        if (b_01)
        {
            if (FlyControl.weapon_qty >= 1)
            {
                this.GetComponent<Renderer>().material.color = colorOn;
            }

            else
            {
                this.GetComponent<Renderer>().material.color = colorOff;
            }
        }

        if (b_02)
        {
            if (FlyControl.weapon_qty >= 2)
            {
                this.GetComponent<Renderer>().material.color = colorOn;
            }

            else
            {
                this.GetComponent<Renderer>().material.color = colorOff;
            }
        }

        if (b_03)
        {
            if (FlyControl.weapon_qty >= 3)
            {
                this.GetComponent<Renderer>().material.color = colorOn;
            }

            else
            {
                this.GetComponent<Renderer>().material.color = colorOff;
            }
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "VR_Button")
        {
            if (b_01)
            {
                Debug.Log("BUTTON 01");
                FlyControl.weapon_qty = 1;
            }

            if (b_02)
            {
                Debug.Log("BUTTON 02");
                FlyControl.weapon_qty = 2;
            }

            if (b_03)
            {
                Debug.Log("BUTTON 03");
                FlyControl.weapon_qty = 3;
            }
        }
    }
}
