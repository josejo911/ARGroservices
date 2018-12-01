using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class virtual1 : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject c1;
    private GameObject vaquero;
    public AudioSource mush1, mush2, mush3, mush4, mush5;


    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("mush 1 presionado");
        //vbButtonObject1.GetComponent<AudioSource>().Play();
        Run1();
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        //vbButtonObject1.GetComponent<AudioSource>().Stop();

    }

    // Use this for initialization
    void Start()
    {

        c1 = GameObject.Find("b1");
        c1.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    void Run1()
    {
        if (!mush1.isPlaying)
        {
            mush2.Stop();
            mush3.Stop();
            mush4.Stop();
            mush5.Stop();
            mush1.Play();
        }
        else
        {
            mush1.Stop();
        }
    }

}